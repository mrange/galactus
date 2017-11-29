namespace Galactus.App.Model
{
  using Galactus.Core;
  using System.Text;

  // --------------------------------------------------------------------------
  // Records
  // --------------------------------------------------------------------------

  sealed partial class Address
  {
    public readonly string CarryOver;
    public readonly string Street;
    public readonly string Zip;
    public readonly string City;
    public readonly string County;
    public readonly string Country;

    public Address(
        string carryOver
      , string street
      , string zip
      , string city
      , string county
      , string country
      )
    {
      CarryOver = carryOver;
      Street = street;
      Zip = zip;
      City = city;
      County = county;
      Country = country;
    }

    public Address()
      : this(
        ""
      , ""
      , ""
      , ""
      , ""
      , ""
      )
    {
    }

    public readonly static Address Zero = new Address();

    public override string ToString()
    {
      var sb = new StringBuilder(16);
      sb.Append("{ Address");
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

    sealed class CarryOverLens : Lens<Address, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("CarryOver");
      }

      public override string Get(Address m)
      {
        return m.CarryOver;
      }

      public override Address Set(Address m, string p)
      {
        return m.With_CarryOver(p);
      }
    }

    public readonly static Lens<Address, string> carryOver = new CarryOverLens();

    public Address With_Street(string street)
    {
      return new Address(
        CarryOver
      , street
      , Zip
      , City
      , County
      , Country
      );
    }

    sealed class StreetLens : Lens<Address, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("Street");
      }

      public override string Get(Address m)
      {
        return m.Street;
      }

      public override Address Set(Address m, string p)
      {
        return m.With_Street(p);
      }
    }

    public readonly static Lens<Address, string> street = new StreetLens();

    public Address With_Zip(string zip)
    {
      return new Address(
        CarryOver
      , Street
      , zip
      , City
      , County
      , Country
      );
    }

    sealed class ZipLens : Lens<Address, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("Zip");
      }

      public override string Get(Address m)
      {
        return m.Zip;
      }

      public override Address Set(Address m, string p)
      {
        return m.With_Zip(p);
      }
    }

    public readonly static Lens<Address, string> zip = new ZipLens();

    public Address With_City(string city)
    {
      return new Address(
        CarryOver
      , Street
      , Zip
      , city
      , County
      , Country
      );
    }

    sealed class CityLens : Lens<Address, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("City");
      }

      public override string Get(Address m)
      {
        return m.City;
      }

      public override Address Set(Address m, string p)
      {
        return m.With_City(p);
      }
    }

    public readonly static Lens<Address, string> city = new CityLens();

    public Address With_County(string county)
    {
      return new Address(
        CarryOver
      , Street
      , Zip
      , City
      , county
      , Country
      );
    }

    sealed class CountyLens : Lens<Address, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("County");
      }

      public override string Get(Address m)
      {
        return m.County;
      }

      public override Address Set(Address m, string p)
      {
        return m.With_County(p);
      }
    }

    public readonly static Lens<Address, string> county = new CountyLens();

    public Address With_Country(string country)
    {
      return new Address(
        CarryOver
      , Street
      , Zip
      , City
      , County
      , country
      );
    }

    sealed class CountryLens : Lens<Address, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("Country");
      }

      public override string Get(Address m)
      {
        return m.Country;
      }

      public override Address Set(Address m, string p)
      {
        return m.With_Country(p);
      }
    }

    public readonly static Lens<Address, string> country = new CountryLens();


  }

  // --------------------------------------------------------------------------
  // Records
  // --------------------------------------------------------------------------

  sealed partial class Customer
  {
    public readonly string FirstName;
    public readonly string LastName;
    public readonly string Email;
    public readonly CustomerKind Kind;
    public readonly bool SeparateDeliveryAddress;
    public readonly Address InvoiceAddress;
    public readonly Address DeliveryAddress;

    public Customer(
        string firstName
      , string lastName
      , string email
      , CustomerKind kind
      , bool separateDeliveryAddress
      , Address invoiceAddress
      , Address deliveryAddress
      )
    {
      FirstName = firstName;
      LastName = lastName;
      Email = email;
      Kind = kind;
      SeparateDeliveryAddress = separateDeliveryAddress;
      InvoiceAddress = invoiceAddress;
      DeliveryAddress = deliveryAddress;
    }

    public Customer()
      : this(
        ""
      , ""
      , ""
      , CustomerKind.Zero
      , default(bool)
      , Address.Zero
      , Address.Zero
      )
    {
    }

    public readonly static Customer Zero = new Customer();

    public override string ToString()
    {
      var sb = new StringBuilder(16);
      sb.Append("{ Customer");
      sb.Append(", FirstName: ");
      sb.Append(FirstName);
      sb.Append(", LastName: ");
      sb.Append(LastName);
      sb.Append(", Email: ");
      sb.Append(Email);
      sb.Append(", Kind: ");
      sb.Append(Kind);
      sb.Append(", SeparateDeliveryAddress: ");
      sb.Append(SeparateDeliveryAddress);
      sb.Append(", InvoiceAddress: ");
      sb.Append(InvoiceAddress);
      sb.Append(", DeliveryAddress: ");
      sb.Append(DeliveryAddress);
      sb.Append(" }");
      return sb.ToString();
    }

    public Customer With_FirstName(string firstName)
    {
      return new Customer(
        firstName
      , LastName
      , Email
      , Kind
      , SeparateDeliveryAddress
      , InvoiceAddress
      , DeliveryAddress
      );
    }

    sealed class FirstNameLens : Lens<Customer, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("FirstName");
      }

      public override string Get(Customer m)
      {
        return m.FirstName;
      }

      public override Customer Set(Customer m, string p)
      {
        return m.With_FirstName(p);
      }
    }

    public readonly static Lens<Customer, string> firstName = new FirstNameLens();

    public Customer With_LastName(string lastName)
    {
      return new Customer(
        FirstName
      , lastName
      , Email
      , Kind
      , SeparateDeliveryAddress
      , InvoiceAddress
      , DeliveryAddress
      );
    }

    sealed class LastNameLens : Lens<Customer, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("LastName");
      }

      public override string Get(Customer m)
      {
        return m.LastName;
      }

      public override Customer Set(Customer m, string p)
      {
        return m.With_LastName(p);
      }
    }

    public readonly static Lens<Customer, string> lastName = new LastNameLens();

    public Customer With_Email(string email)
    {
      return new Customer(
        FirstName
      , LastName
      , email
      , Kind
      , SeparateDeliveryAddress
      , InvoiceAddress
      , DeliveryAddress
      );
    }

    sealed class EmailLens : Lens<Customer, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("Email");
      }

      public override string Get(Customer m)
      {
        return m.Email;
      }

      public override Customer Set(Customer m, string p)
      {
        return m.With_Email(p);
      }
    }

    public readonly static Lens<Customer, string> email = new EmailLens();

    public Customer With_Kind(CustomerKind kind)
    {
      return new Customer(
        FirstName
      , LastName
      , Email
      , kind
      , SeparateDeliveryAddress
      , InvoiceAddress
      , DeliveryAddress
      );
    }

    sealed class KindLens : Lens<Customer, CustomerKind>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("Kind");
      }

      public override CustomerKind Get(Customer m)
      {
        return m.Kind;
      }

      public override Customer Set(Customer m, CustomerKind p)
      {
        return m.With_Kind(p);
      }
    }

    public readonly static Lens<Customer, CustomerKind> kind = new KindLens();

    public Customer With_SeparateDeliveryAddress(bool separateDeliveryAddress)
    {
      return new Customer(
        FirstName
      , LastName
      , Email
      , Kind
      , separateDeliveryAddress
      , InvoiceAddress
      , DeliveryAddress
      );
    }

    sealed class SeparateDeliveryAddressLens : Lens<Customer, bool>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("SeparateDeliveryAddress");
      }

      public override bool Get(Customer m)
      {
        return m.SeparateDeliveryAddress;
      }

      public override Customer Set(Customer m, bool p)
      {
        return m.With_SeparateDeliveryAddress(p);
      }
    }

    public readonly static Lens<Customer, bool> separateDeliveryAddress = new SeparateDeliveryAddressLens();

    public Customer With_InvoiceAddress(Address invoiceAddress)
    {
      return new Customer(
        FirstName
      , LastName
      , Email
      , Kind
      , SeparateDeliveryAddress
      , invoiceAddress
      , DeliveryAddress
      );
    }

    sealed class InvoiceAddressLens : Lens<Customer, Address>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("InvoiceAddress");
      }

      public override Address Get(Customer m)
      {
        return m.InvoiceAddress;
      }

      public override Customer Set(Customer m, Address p)
      {
        return m.With_InvoiceAddress(p);
      }
    }

    public readonly static Lens<Customer, Address> invoiceAddress = new InvoiceAddressLens();

    public Customer With_DeliveryAddress(Address deliveryAddress)
    {
      return new Customer(
        FirstName
      , LastName
      , Email
      , Kind
      , SeparateDeliveryAddress
      , InvoiceAddress
      , deliveryAddress
      );
    }

    sealed class DeliveryAddressLens : Lens<Customer, Address>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("DeliveryAddress");
      }

      public override Address Get(Customer m)
      {
        return m.DeliveryAddress;
      }

      public override Customer Set(Customer m, Address p)
      {
        return m.With_DeliveryAddress(p);
      }
    }

    public readonly static Lens<Customer, Address> deliveryAddress = new DeliveryAddressLens();


  }

  // --------------------------------------------------------------------------
  // Unions 
  // --------------------------------------------------------------------------

  abstract partial class CustomerKind
  {
    public readonly static CustomerKind Zero = new Individual();

    public partial interface IVisitor<out T>
    { 
      T Visit(Individual v);
      T Visit(Company v);
    }

    public abstract T Apply<T>(IVisitor<T> visitor);
  }

  sealed partial class Individual : CustomerKind
  {
    public readonly string SocialNo;

    public Individual(
        string socialNo
      )
    {
      SocialNo = socialNo;
    }

    public Individual()
      : this(
        ""
      )
    {
    }

    public readonly static Individual Zero = new Individual();

    public override string ToString()
    {
      var sb = new StringBuilder(16);
      sb.Append("{ Individual");
      sb.Append(", SocialNo: ");
      sb.Append(SocialNo);
      sb.Append(" }");
      return sb.ToString();
    }

    public Individual With_SocialNo(string socialNo)
    {
      return new Individual(
        socialNo
      );
    }

    sealed class SocialNoLens : Lens<Individual, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("SocialNo");
      }

      public override string Get(Individual m)
      {
        return m.SocialNo;
      }

      public override Individual Set(Individual m, string p)
      {
        return m.With_SocialNo(p);
      }
    }

    public readonly static Lens<Individual, string> socialNo = new SocialNoLens();

    public override T Apply<T>(IVisitor<T> visitor)
    {
      return visitor.Visit(this);
    }

  }

  sealed partial class Company : CustomerKind
  {
    public readonly string CompanyId;
    public readonly string VatNo;

    public Company(
        string companyId
      , string vatNo
      )
    {
      CompanyId = companyId;
      VatNo = vatNo;
    }

    public Company()
      : this(
        ""
      , ""
      )
    {
    }

    public readonly static Company Zero = new Company();

    public override string ToString()
    {
      var sb = new StringBuilder(16);
      sb.Append("{ Company");
      sb.Append(", CompanyId: ");
      sb.Append(CompanyId);
      sb.Append(", VatNo: ");
      sb.Append(VatNo);
      sb.Append(" }");
      return sb.ToString();
    }

    public Company With_CompanyId(string companyId)
    {
      return new Company(
        companyId
      , VatNo
      );
    }

    sealed class CompanyIdLens : Lens<Company, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("CompanyId");
      }

      public override string Get(Company m)
      {
        return m.CompanyId;
      }

      public override Company Set(Company m, string p)
      {
        return m.With_CompanyId(p);
      }
    }

    public readonly static Lens<Company, string> companyId = new CompanyIdLens();

    public Company With_VatNo(string vatNo)
    {
      return new Company(
        CompanyId
      , vatNo
      );
    }

    sealed class VatNoLens : Lens<Company, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("VatNo");
      }

      public override string Get(Company m)
      {
        return m.VatNo;
      }

      public override Company Set(Company m, string p)
      {
        return m.With_VatNo(p);
      }
    }

    public readonly static Lens<Company, string> vatNo = new VatNoLens();

    public override T Apply<T>(IVisitor<T> visitor)
    {
      return visitor.Visit(this);
    }

  }

}
