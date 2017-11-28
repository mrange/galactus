# GUI code through a different lens

Too long have good programmers neglected GUI code because it's too hard. Instead they have focused on writing backend code which is comparably a simpler domain.

We all seen the horribly spaghetti GUI code in a program that grown too fast. We all seen the over engineered sluggish GUI code in a program that grown too slow.

We don't want that. We want it to be simple to create composable and responsive GUI code that don't turn into spaghetti.

The event driven model + mutable state tend to generate spaghetti. OOP tend to not compose as powerful as FP.

Let's write functional GUI code in WPF:

## A silly and useless example

```csharp
namespace Galactus.App.Demo
{
  using Galactus.Core;

  using static Galactus.Standard.Controls<string>;

  class Program
  {
    static IView<string> View(string model)
    {
      return textBox.View(textBox.text(model));
    }

    static string Update(string model, string message)
    {
      return model + message;
    }

    public static void Run()
    {
      Hosts.OpenWindow("Hello", View, Update);
    }
  }
}
```

Let's all ignore everything for now except the `View` function. The `View` function generates the user interface from an model. The model in this case is just a simple string but it can be any type. The user interface in our case is a  textbox that says _Hello_ (because the model is a "Hello" string).

We can wrap the textbox in a border:

```csharp
static IView<string> View(string model)
{
  return border.View
    ( border.borderBrush(Brushes.LimeGreen)
    , border.borderThickness(new Thickness(8))
    )(textBox.View(textBox.text(model)))
    ;
}
```

Let's say we like this green border so much we want to use it everywhere in our user interface. How can we reuse it? A sub class? WPF styles? Nah, let's just make a function called `happyBorder`.

```csharp
static IView<string> View(string model)
{
  IView<string> happyBorder(IView<string> view) =>
    border.View
      ( border.borderBrush(Brushes.LimeGreen)
      , border.borderThickness(new Thickness(8))
      )(view)
      ;

  return happyBorder(textBox.View(textBox.text(model)));
}
```

Now we can create a more complex user interface with lots of happy borders:

```csharp
static IView<string> View(string model)
{
  IView<string> happyBorder(IView<string> view) =>
    border.View
      ( border.borderBrush(Brushes.LimeGreen)
      , border.borderThickness(new Thickness(8))
      )(view)
      ;

  return happyBorder(
    stackPanel.View
      ( stackPanel.orientation(Orientation.Vertical)
      )
      ( happyBorder(textBlock.View(textBlock.text("Green is best")))
      , happyBorder(textBox.View(textBox.text(model)))
      )
    )
    ;
}
```

The example is silly but it shows that you can create user interface composition using normal functions.

Let's add a button.

```csharp
static IView<string> View(string model)
{
  IView<string> happyBorder(IView<string> view) =>
    border.View
      ( border.borderBrush(Brushes.LimeGreen)
      , border.borderThickness(new Thickness(8))
      )(view)
      ;

  return happyBorder(
    stackPanel.View
      ( stackPanel.orientation(Orientation.Vertical)
      )
      ( happyBorder(textBlock.View(textBlock.text("Green is best")))
      , happyBorder(textBox.View(textBox.text(model)))
      )
    )
    ;
}
```

```csharp
static IView<string> View(string model)
{
  return stackPanel.View
    ( stackPanel.orientation(Orientation.Vertical)
    )
    ( textBox.View(textBox.text(model))
    , button.View()(textBlock.View(textBlock.text("Click me!")))
    )
    ;
}
```

We have a button but nothing happens when we click it. Let's add an event.

```csharp
static IView<string> View(string model)
{
  return stackPanel.View
    ( stackPanel.orientation(Orientation.Vertical)
    )
    ( textBox.View(textBox.text(model))
    , button.View
      (button.onClick((ui, args) => "There!"))
      (textBlock.View(textBlock.text("Click me!")))
    )
    ;
}
```

The mental model here is that whenever an event fires you generate a message, don't modify the user interface element. The message will be used by the `Update` function to combine the existing model with the message. In our simple case the message is a simple string as well.

Let's look at the `Update` function:

```csharp
static string Update(string model, string message)
{
  return model + message;
}
```

The `Update` function takes the existing model and just concatenates the message which gives us a user interface that grows the `TextBox` string more and more.

## A slightly more useful example

Let's define a `Customer` and `Message` like so:

```csharp
class Customer
{
  public string FirstName ;
  public string LastName  ;
  public bool   IsFemale  ;
}
// The message when executed will mutate the customer
delegate void Message(Customer customer);
```

We would like a simple user interface to manage this model:

First try would be something like this:

```csharp
static IView<Message> View(Customer model)
{
  var margin = frameworkElement.margin(new Thickness(4));

  IView<Message> labeledText(string label, string value) =>
    stackPanel.View
      ( stackPanel.orientation(Orientation.Horizontal)
      , margin
      )
      ( textBlock.View(textBlock.text(label), textBlock.width(80))
      , textBox.View(textBox.text(value), textBox.minWidth(120))
      )
      ;

  IView<Message> labeledCheckBox(string label, bool value) =>
    checkBox.View
      ( checkBox.isChecked(value)
      , margin
      )
      ( textBlock.View(textBlock.text(label))
      )
      ;

  return stackPanel.View
    ( stackPanel.orientation(Orientation.Vertical))
    ( labeledText     ("First name" , model.FirstName)
    , labeledText     ("Last name"  , model.LastName)
    , labeledCheckBox ("Is female?" , model.IsFemale)
    )
    ;
}
```

We have created some helper functions to make it easy to create textboxes and checkboxes with labels.

A big problem is that we don't get updates back from the user interface to the model, this is what we usually use two-way bindings for in WPF. An attempt to fix this is to make sure `labeledText` takes a callback that will mutate the model.

```csharp
IView<Message> labeledText(string label, string value, Action<Customer, string> action) =>
  stackPanel.View
    ( stackPanel.orientation(Orientation.Horizontal)
    , margin
    )
    ( textBlock.View(textBlock.text(label), textBlock.width(80))
    , textBox.View(textBox.text(value), textBox.minWidth(120)
    , textBox.onLostFocus((ui, args) => c => action(c, ((TextBox)ui).Text)))
    )
    ;
```

`labeledText` is much like before except it also has a callback that will be invoked when the `TextBox` loses focus allowing the callback to modify the model with the new input. `onLostFocus` handler creates a `Message` which will be applied to the model in the `Update` function:

```csharp
static Customer Update(Customer model, Message message)
{
  message(model);
  return model;
}
```

We also creates a new `labeledCheckBox`:

```csharp
IView<Message> labeledCheckBox(string label, bool? value, Action<Customer, bool?> action) =>
  checkBox.View
    ( checkBox.isChecked(value)
    , checkBox.onClick((ui, args) => c => action(c, ((CheckBox)ui).IsChecked))
    , margin
    )
    ( textBlock.View(textBlock.text(label))
    )
    ;
```

Putting it together:

```csharp
return stackPanel.View
  ( stackPanel.orientation(Orientation.Vertical))
  ( labeledText     ("First name" , model.FirstName , (c, v) => c.FirstName = v)
  , labeledText     ("Last name"  , model.LastName  , (c, v) => c.LastName  = v)
  , labeledCheckBox ("Is female?" , model.IsFemale  , (c, v) => c.IsFemale  = v)
  )
  ;
```

Now the user interface modifies the model.

## Some ugly facts

While the above example works it has two major problems:

1. FP implies immutability, without immutability composing is not predictable. In our example we uses a mutable customer state.
2. We have to provide a value and a callback in our call to `labeledText`. It feels redundant and clunky.

A common pattern when dealing with immutable structures is `Withers`. This pattern allows updating of individual fields while preserving the others.

```csharp
// FirstName and LastName replaced in newCustomer, all other fields are as before
var newCustomer = customer.WithFirstName("Bill").WithLastName("Gates");
```

This doesn't feel as good when doing updates to nested fields:

```csharp
var invoiceAddress  = customer.InvoiceAddress;
var deliveryAddress = customer.DeliveryAddress;
var newCustomer     = customer
  .WithFirstName("Bill")
  .WithLastName("Gates")
  .WithInvoiceAddress(invoiceAddress.WithCarryOver("Melinda Gates"))
  .WithDeliveryAddress(deliveryAddress.WithCarryOver("Melinda Gates"))
  ;
```

So it would be great if there was a pattern that allowed us update immutable nested models without the need to declare an value and a callback.

That pattern is called a `Lens`. A very simple implementation of a `Lens`:

## Lenses

```csharp
public interface ILens<M, P>
{
  P Get(M m);
  M Set(M m, P p);
}
```

A `Lens` is like a functional version of the C# property, it supports `Get` and `Set` but `Set` doesn't mutate the original instance, it returns a new instance with the new value. Like many functional patterns `Lenses` are composable which gives them great powers.

Let's imagine a slightly more advanced model than before:

```csharp
public class Address
{
  public readonly string CarryOver;
  public readonly string Street;
  public readonly string Zip;
  public readonly string City;
  public readonly string County;
  public readonly string Country;

  public Address(
    , string carryOver
    , string street
    , string zip
    , string city
    , string county
    , string country
    )
  {
    // TODO: Implement
  }

  public Address With_CarryOver(string carryOver)
  {
    return new Address(
      carryOver
    , Street
    , Zip
    , City
    , County
    , Country
    );
  }

  // One wither and one lens

  public Address WithCarryOver(string carryOver)
  {
    // TODO: Implement
  }

  sealed class CarryOverLens : ILens<Address, string>
  {
    // TODO: Implement
  }

  public readonly static Lens<Address, string> carryOver = new CarryOverLens();
}

public class Customer
{
  public readonly string FirstName;
  public readonly string LastName;
  public readonly bool SeparateDeliveryAddress;
  public readonly Address InvoiceAddress;
  public readonly Address DeliveryAddress;

  public Customer(
      string firstName
    , string lastName
    , bool separateDeliveryAddress
    , Address invoiceAddress
    , Address deliveryAddress
    )
  {
    // TODO: Implement
  }

  // One wither and one lens

  public Customer WithInvoiceAddress(Address invoiceAddress)
  {
    // TODO: Implement
  }

  sealed class InvoiceAddressLens : ILens<Customer, Address>
  {
    // TODO: Implement
  }

  public readonly static Lens<Customer, Address> invoiceAddress = new InvoiceAddressLens();
}
```

This model is immutable and have `Withers` and `Lenses` to simplify working the model.

Updating a nested fields in an immutable model using lenses could look like this:

```csharp
var setCarryOver  = Address.carryOver.Set("Melinda Gates");
var newCustomer   = Lens.SetAll
  ( customer
  , Customer.firstName      .Set("Bill")
  , Customer.lastName       .Set("Gates")
  , Customer.invoiceAddress .Set(setCarryOver)
  , Customer.deliveryAddress.Set(setCarryOver)
  );
```

Lenses allows us to work with nested immutable models but in addition a Lens is a combination of a getter and a setter which is what we need in order to make our user interface code look better.

Instead of this with a mutable model:

```csharp
return stackPanel.View
  ( stackPanel.orientation(Orientation.Vertical))
  ( labeledText     ("First name" , model.FirstName , (c, v) => c.FirstName = v)
  , labeledText     ("Last name"  , model.LastName  , (c, v) => c.LastName  = v)
  , labeledCheckBox ("Is female?" , model.IsFemale  , (c, v) => c.IsFemale  = v)
  )
  ;
```

We want to end up here using a immutable model + lenses:

```csharp
return stackPanel.View
  ( stackPanel.orientation(Orientation.Vertical))
  ( labeledText     ("First name" , Customer.firstName)
  , labeledText     ("Last name"  , Customer.lastName )
  , labeledCheckBox ("Is female?" , Customer.isFemale )
  )
  ;
```
