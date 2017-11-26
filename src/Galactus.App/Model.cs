namespace Galactus.App.Test
{
  using Galactus.Core;
  using System.Text;

  public sealed partial class AddressInfo
  {
    public readonly string FirstName;
    public readonly string LastName;
    public readonly string CarryOver;
    public readonly string Street;
    public readonly string Zip;
    public readonly string City;
    public readonly string County;
    public readonly string Country;

    public AddressInfo(
        string firstName
      , string lastName
      , string carryOver
      , string street
      , string zip
      , string city
      , string county
      , string country
      )
    {
      FirstName = firstName;
      LastName = lastName;
      CarryOver = carryOver;
      Street = street;
      Zip = zip;
      City = city;
      County = county;
      Country = country;
    }
 
  public override string ToString()
  {
    var sb = new StringBuilder(16);
    sb.Append("{ AddressInfo");
    sb.Append(", FirstName: ");
    sb.Append(FirstName);
    sb.Append(", LastName: ");
    sb.Append(LastName);
    sb.Append(", CarryOver: ");
    sb.Append(CarryOver);
    sb.Append(", Street: ");
    sb.Append(Street);
    sb.Append(", Zip: ");
    sb.Append(Zip);
    sb.Append(", City: ");
    sb.Append(City);
    sb.Append(", County: ");
    sb.Append(County);
    sb.Append(", Country: ");
    sb.Append(Country);
    sb.Append(" }");
    return sb.ToString();
  }

    public AddressInfo With_FirstName(string firstName)
    {
      return new AddressInfo(
        firstName
      , LastName
      , CarryOver
      , Street
      , Zip
      , City
      , County
      , Country
      );
    }

    sealed class FirstNameLens : Lens<AddressInfo, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("FirstName");
      }

      public override string Get(AddressInfo m)
      {
        return m.FirstName;
      }

      public override AddressInfo Set(AddressInfo m, string p)
      {
        return m.With_FirstName(p);
      }
    }

    public readonly static Lens<AddressInfo, string> firstName = new FirstNameLens();

    public AddressInfo With_LastName(string lastName)
    {
      return new AddressInfo(
        FirstName
      , lastName
      , CarryOver
      , Street
      , Zip
      , City
      , County
      , Country
      );
    }

    sealed class LastNameLens : Lens<AddressInfo, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("LastName");
      }

      public override string Get(AddressInfo m)
      {
        return m.LastName;
      }

      public override AddressInfo Set(AddressInfo m, string p)
      {
        return m.With_LastName(p);
      }
    }

    public readonly static Lens<AddressInfo, string> lastName = new LastNameLens();

    public AddressInfo With_CarryOver(string carryOver)
    {
      return new AddressInfo(
        FirstName
      , LastName
      , carryOver
      , Street
      , Zip
      , City
      , County
      , Country
      );
    }

    sealed class CarryOverLens : Lens<AddressInfo, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("CarryOver");
      }

      public override string Get(AddressInfo m)
      {
        return m.CarryOver;
      }

      public override AddressInfo Set(AddressInfo m, string p)
      {
        return m.With_CarryOver(p);
      }
    }

    public readonly static Lens<AddressInfo, string> carryOver = new CarryOverLens();

    public AddressInfo With_Street(string street)
    {
      return new AddressInfo(
        FirstName
      , LastName
      , CarryOver
      , street
      , Zip
      , City
      , County
      , Country
      );
    }

    sealed class StreetLens : Lens<AddressInfo, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("Street");
      }

      public override string Get(AddressInfo m)
      {
        return m.Street;
      }

      public override AddressInfo Set(AddressInfo m, string p)
      {
        return m.With_Street(p);
      }
    }

    public readonly static Lens<AddressInfo, string> street = new StreetLens();

    public AddressInfo With_Zip(string zip)
    {
      return new AddressInfo(
        FirstName
      , LastName
      , CarryOver
      , Street
      , zip
      , City
      , County
      , Country
      );
    }

    sealed class ZipLens : Lens<AddressInfo, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("Zip");
      }

      public override string Get(AddressInfo m)
      {
        return m.Zip;
      }

      public override AddressInfo Set(AddressInfo m, string p)
      {
        return m.With_Zip(p);
      }
    }

    public readonly static Lens<AddressInfo, string> zip = new ZipLens();

    public AddressInfo With_City(string city)
    {
      return new AddressInfo(
        FirstName
      , LastName
      , CarryOver
      , Street
      , Zip
      , city
      , County
      , Country
      );
    }

    sealed class CityLens : Lens<AddressInfo, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("City");
      }

      public override string Get(AddressInfo m)
      {
        return m.City;
      }

      public override AddressInfo Set(AddressInfo m, string p)
      {
        return m.With_City(p);
      }
    }

    public readonly static Lens<AddressInfo, string> city = new CityLens();

    public AddressInfo With_County(string county)
    {
      return new AddressInfo(
        FirstName
      , LastName
      , CarryOver
      , Street
      , Zip
      , City
      , county
      , Country
      );
    }

    sealed class CountyLens : Lens<AddressInfo, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("County");
      }

      public override string Get(AddressInfo m)
      {
        return m.County;
      }

      public override AddressInfo Set(AddressInfo m, string p)
      {
        return m.With_County(p);
      }
    }

    public readonly static Lens<AddressInfo, string> county = new CountyLens();

    public AddressInfo With_Country(string country)
    {
      return new AddressInfo(
        FirstName
      , LastName
      , CarryOver
      , Street
      , Zip
      , City
      , County
      , country
      );
    }

    sealed class CountryLens : Lens<AddressInfo, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("Country");
      }

      public override string Get(AddressInfo m)
      {
        return m.Country;
      }

      public override AddressInfo Set(AddressInfo m, string p)
      {
        return m.With_Country(p);
      }
    }

    public readonly static Lens<AddressInfo, string> country = new CountryLens();


  }

  public sealed partial class Model
  {
    public readonly bool SeparateDeliveryAddress;
    public readonly AddressInfo InvoiceAddress;
    public readonly AddressInfo DeliveryAddress;

    public Model(
        bool separateDeliveryAddress
      , AddressInfo invoiceAddress
      , AddressInfo deliveryAddress
      )
    {
      SeparateDeliveryAddress = separateDeliveryAddress;
      InvoiceAddress = invoiceAddress;
      DeliveryAddress = deliveryAddress;
    }
 
  public override string ToString()
  {
    var sb = new StringBuilder(16);
    sb.Append("{ Model");
    sb.Append(", SeparateDeliveryAddress: ");
    sb.Append(SeparateDeliveryAddress);
    sb.Append(", InvoiceAddress: ");
    sb.Append(InvoiceAddress);
    sb.Append(", DeliveryAddress: ");
    sb.Append(DeliveryAddress);
    sb.Append(" }");
    return sb.ToString();
  }

    public Model With_SeparateDeliveryAddress(bool separateDeliveryAddress)
    {
      return new Model(
        separateDeliveryAddress
      , InvoiceAddress
      , DeliveryAddress
      );
    }

    sealed class SeparateDeliveryAddressLens : Lens<Model, bool>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("SeparateDeliveryAddress");
      }

      public override bool Get(Model m)
      {
        return m.SeparateDeliveryAddress;
      }

      public override Model Set(Model m, bool p)
      {
        return m.With_SeparateDeliveryAddress(p);
      }
    }

    public readonly static Lens<Model, bool> separateDeliveryAddress = new SeparateDeliveryAddressLens();

    public Model With_InvoiceAddress(AddressInfo invoiceAddress)
    {
      return new Model(
        SeparateDeliveryAddress
      , invoiceAddress
      , DeliveryAddress
      );
    }

    sealed class InvoiceAddressLens : Lens<Model, AddressInfo>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("InvoiceAddress");
      }

      public override AddressInfo Get(Model m)
      {
        return m.InvoiceAddress;
      }

      public override Model Set(Model m, AddressInfo p)
      {
        return m.With_InvoiceAddress(p);
      }
    }

    public readonly static Lens<Model, AddressInfo> invoiceAddress = new InvoiceAddressLens();

    public Model With_DeliveryAddress(AddressInfo deliveryAddress)
    {
      return new Model(
        SeparateDeliveryAddress
      , InvoiceAddress
      , deliveryAddress
      );
    }

    sealed class DeliveryAddressLens : Lens<Model, AddressInfo>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("DeliveryAddress");
      }

      public override AddressInfo Get(Model m)
      {
        return m.DeliveryAddress;
      }

      public override Model Set(Model m, AddressInfo p)
      {
        return m.With_DeliveryAddress(p);
      }
    }

    public readonly static Lens<Model, AddressInfo> deliveryAddress = new DeliveryAddressLens();


  }

}
