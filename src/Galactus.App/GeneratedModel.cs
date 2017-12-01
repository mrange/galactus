﻿namespace Galactus.App.Model
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

    sealed class CarryOverPrism : Prism<Address, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("CarryOver");
      }

      public override Maybe<string> Get(Address m)
      {
        return m.CarryOver.Just();
      }

      public override Address Set(Address m, string p)
      {
        return m.With_CarryOver(p);
      }
    }

    public readonly static Prism<Address, string> carryOver = new CarryOverPrism();

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

    sealed class StreetPrism : Prism<Address, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("Street");
      }

      public override Maybe<string> Get(Address m)
      {
        return m.Street.Just();
      }

      public override Address Set(Address m, string p)
      {
        return m.With_Street(p);
      }
    }

    public readonly static Prism<Address, string> street = new StreetPrism();

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

    sealed class ZipPrism : Prism<Address, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("Zip");
      }

      public override Maybe<string> Get(Address m)
      {
        return m.Zip.Just();
      }

      public override Address Set(Address m, string p)
      {
        return m.With_Zip(p);
      }
    }

    public readonly static Prism<Address, string> zip = new ZipPrism();

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

    sealed class CityPrism : Prism<Address, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("City");
      }

      public override Maybe<string> Get(Address m)
      {
        return m.City.Just();
      }

      public override Address Set(Address m, string p)
      {
        return m.With_City(p);
      }
    }

    public readonly static Prism<Address, string> city = new CityPrism();

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

    sealed class CountyPrism : Prism<Address, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("County");
      }

      public override Maybe<string> Get(Address m)
      {
        return m.County.Just();
      }

      public override Address Set(Address m, string p)
      {
        return m.With_County(p);
      }
    }

    public readonly static Prism<Address, string> county = new CountyPrism();

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

    sealed class CountryPrism : Prism<Address, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("Country");
      }

      public override Maybe<string> Get(Address m)
      {
        return m.Country.Just();
      }

      public override Address Set(Address m, string p)
      {
        return m.With_Country(p);
      }
    }

    public readonly static Prism<Address, string> country = new CountryPrism();


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

    sealed class FirstNamePrism : Prism<Customer, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("FirstName");
      }

      public override Maybe<string> Get(Customer m)
      {
        return m.FirstName.Just();
      }

      public override Customer Set(Customer m, string p)
      {
        return m.With_FirstName(p);
      }
    }

    public readonly static Prism<Customer, string> firstName = new FirstNamePrism();

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

    sealed class LastNamePrism : Prism<Customer, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("LastName");
      }

      public override Maybe<string> Get(Customer m)
      {
        return m.LastName.Just();
      }

      public override Customer Set(Customer m, string p)
      {
        return m.With_LastName(p);
      }
    }

    public readonly static Prism<Customer, string> lastName = new LastNamePrism();

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

    sealed class EmailPrism : Prism<Customer, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("Email");
      }

      public override Maybe<string> Get(Customer m)
      {
        return m.Email.Just();
      }

      public override Customer Set(Customer m, string p)
      {
        return m.With_Email(p);
      }
    }

    public readonly static Prism<Customer, string> email = new EmailPrism();

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

    sealed class KindPrism : Prism<Customer, CustomerKind>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("Kind");
      }

      public override Maybe<CustomerKind> Get(Customer m)
      {
        return m.Kind.Just();
      }

      public override Customer Set(Customer m, CustomerKind p)
      {
        return m.With_Kind(p);
      }
    }

    public readonly static Prism<Customer, CustomerKind> kind = new KindPrism();

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

    sealed class SeparateDeliveryAddressPrism : Prism<Customer, bool>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("SeparateDeliveryAddress");
      }

      public override Maybe<bool> Get(Customer m)
      {
        return m.SeparateDeliveryAddress.Just();
      }

      public override Customer Set(Customer m, bool p)
      {
        return m.With_SeparateDeliveryAddress(p);
      }
    }

    public readonly static Prism<Customer, bool> separateDeliveryAddress = new SeparateDeliveryAddressPrism();

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

    sealed class InvoiceAddressPrism : Prism<Customer, Address>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("InvoiceAddress");
      }

      public override Maybe<Address> Get(Customer m)
      {
        return m.InvoiceAddress.Just();
      }

      public override Customer Set(Customer m, Address p)
      {
        return m.With_InvoiceAddress(p);
      }
    }

    public readonly static Prism<Customer, Address> invoiceAddress = new InvoiceAddressPrism();

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

    sealed class DeliveryAddressPrism : Prism<Customer, Address>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("DeliveryAddress");
      }

      public override Maybe<Address> Get(Customer m)
      {
        return m.DeliveryAddress.Just();
      }

      public override Customer Set(Customer m, Address p)
      {
        return m.With_DeliveryAddress(p);
      }
    }

    public readonly static Prism<Customer, Address> deliveryAddress = new DeliveryAddressPrism();


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

    sealed class IndividualPrism : Prism<CustomerKind, Individual>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("|Individual");
      }

      public override Maybe<Individual> Get(CustomerKind m)
      {
        var mm = m as Individual;
        if (mm != null)
        {
          return mm.Just();
        }
        else
        {
          return Maybe.Nothing<Individual>();
        }
      }

      public override CustomerKind Set(CustomerKind m, Individual p)
      {
        return p;
      }
    }

    public readonly static Prism<CustomerKind, Individual> individual = new IndividualPrism();

    sealed class CompanyPrism : Prism<CustomerKind, Company>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("|Company");
      }

      public override Maybe<Company> Get(CustomerKind m)
      {
        var mm = m as Company;
        if (mm != null)
        {
          return mm.Just();
        }
        else
        {
          return Maybe.Nothing<Company>();
        }
      }

      public override CustomerKind Set(CustomerKind m, Company p)
      {
        return p;
      }
    }

    public readonly static Prism<CustomerKind, Company> company = new CompanyPrism();

  }

  sealed partial class Individual : CustomerKind
  {
    public readonly string SocialId;

    public Individual(
        string socialId
      )
    {
      SocialId = socialId;
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
      sb.Append(", SocialId: ");
      sb.Append(SocialId);
      sb.Append(" }");
      return sb.ToString();
    }

    public Individual With_SocialId(string socialId)
    {
      return new Individual(
        socialId
      );
    }

    sealed class SocialIdPrism : Prism<Individual, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("SocialId");
      }

      public override Maybe<string> Get(Individual m)
      {
        return m.SocialId.Just();
      }

      public override Individual Set(Individual m, string p)
      {
        return m.With_SocialId(p);
      }
    }

    public readonly static Prism<Individual, string> socialId = new SocialIdPrism();

    public override T Apply<T>(IVisitor<T> visitor)
    {
      return visitor.Visit(this);
    }

  }

  sealed partial class Company : CustomerKind
  {
    public readonly string CompanyId;
    public readonly string CompanyName;
    public readonly string VatNo;

    public Company(
        string companyId
      , string companyName
      , string vatNo
      )
    {
      CompanyId = companyId;
      CompanyName = companyName;
      VatNo = vatNo;
    }

    public Company()
      : this(
        ""
      , ""
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
      sb.Append(", CompanyName: ");
      sb.Append(CompanyName);
      sb.Append(", VatNo: ");
      sb.Append(VatNo);
      sb.Append(" }");
      return sb.ToString();
    }

    public Company With_CompanyId(string companyId)
    {
      return new Company(
        companyId
      , CompanyName
      , VatNo
      );
    }

    sealed class CompanyIdPrism : Prism<Company, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("CompanyId");
      }

      public override Maybe<string> Get(Company m)
      {
        return m.CompanyId.Just();
      }

      public override Company Set(Company m, string p)
      {
        return m.With_CompanyId(p);
      }
    }

    public readonly static Prism<Company, string> companyId = new CompanyIdPrism();

    public Company With_CompanyName(string companyName)
    {
      return new Company(
        CompanyId
      , companyName
      , VatNo
      );
    }

    sealed class CompanyNamePrism : Prism<Company, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("CompanyName");
      }

      public override Maybe<string> Get(Company m)
      {
        return m.CompanyName.Just();
      }

      public override Company Set(Company m, string p)
      {
        return m.With_CompanyName(p);
      }
    }

    public readonly static Prism<Company, string> companyName = new CompanyNamePrism();

    public Company With_VatNo(string vatNo)
    {
      return new Company(
        CompanyId
      , CompanyName
      , vatNo
      );
    }

    sealed class VatNoPrism : Prism<Company, string>
    {
      public override void BuildPath(StringBuilder sb)
      {
        sb.Append("VatNo");
      }

      public override Maybe<string> Get(Company m)
      {
        return m.VatNo.Just();
      }

      public override Company Set(Company m, string p)
      {
        return m.With_VatNo(p);
      }
    }

    public readonly static Prism<Company, string> vatNo = new VatNoPrism();

    public override T Apply<T>(IVisitor<T> visitor)
    {
      return visitor.Visit(this);
    }

  }

}
