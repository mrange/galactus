

namespace Galactus.Standard
{
  using Galactus.Core;

  public static partial class Properties
  {
    public partial class uIElement
    {
      public static readonly IProperty<System.Windows.UIElement, ILens> lens = new Property<System.Windows.UIElement, ILens>(DependencyProperties.LensProperty);
    }
  }

  public static partial class Controls<TMessage>
  {
    public partial class empty
    {
      public static IView<TMessage> View = new EmptyView<TMessage> ();
    }

    public partial class uIElement
    {
      public static IValue<TMessage, System.Windows.UIElement> lens(ILens v) => new SetValue<TMessage, System.Windows.UIElement, ILens>(Properties.uIElement.lens, v);
    }
  }
}