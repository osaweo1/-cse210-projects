using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
         Address customerAddress1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer firstCustomer = new Customer("Faraday Smith", customerAddress1);

        Order order1 = new Order(firstCustomer);
        order1.AddProduct(new Product("Televison", "224ND", 1400, 1));
        order1.AddProduct(new Product("Laptop", "P200", 2500, 2));

        Console.WriteLine(order1.GetPackagingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
        Console.WriteLine();

        Address customerAdress2= new Address(
            "75 Ebvomodu street",
            "Benin",
            "Edo",
            "NG"

        );

        Customer SecondCustomer = new Customer(
            "Osawe Osamudiamen",
            customerAdress2
        );

        Order order2 = new Order(
            SecondCustomer);
            order2.AddProduct(new Product("Pressing Iron","ND34X", 23000,2));
            order2.AddProduct(new Product("Cooker","2344", 40000,1));

            Console.WriteLine(order2.GetPackagingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine("Total Price: $" + order1.GetTotalPrice());
            Console.WriteLine();
    }
}


public class Product
{
    private string _name;
    private string _productId;

    private double _price;
    private int _quantity;

    public  Product(string name, string productId, double price, int quantity)
    {
        _name=name;
        _productId=productId;
        _price=price;
        _quantity=quantity;
    }

    public double GetTotalCost()
    {
        return _quantity * _price;
    }

    public string GetProductName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }
    public int GetQuantity()
    {
        return _quantity;
    }

}

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _city=city;
        _street=street;
        _state=state;
        _country=country;
    }

    public bool IsInUsa()
    {
        return _country.ToUpper() == "USA";
    }
    public string GetFullAddress()
    {
        return  _street + "\n" + _city +"\n" + _state + "\n"+ _country;
    }
}

public class Customer
{
    private string _custormerName;
    private Address _address;
    
    public Customer(string custormerName, Address address)
    {
        _custormerName=custormerName;
        _address=address;
    }

    public bool InUsa()
    {
        return _address.IsInUsa();
    }

    public string GetCustormerName()
    {
        return _custormerName;
    }

    public string GetShippingAddress()
    {
       return  _address.GetFullAddress();
    }
}

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products= new List<Product>();
        _customer=customer;
    }

    public void AddProduct( Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total=0;
        // caalculating the total price of product by quantity
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();

        }
        if (_customer.InUsa())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return  total;
    }
    public string GetPackagingLabel()
    {
        string label="Packaging \n";

        foreach (Product product in _products)
        {
            label +="Item Name" +":"+ product.GetProductName() +"\n" + "ID: "+
            product.GetProductId()+ "\n"+
            "Quantity:"+ product.GetQuantity()+","+"\n";
        }


        return label;
    }

    public string GetShippingLabel()
    {
        return  "Shipping Details \n" + _customer.GetCustormerName() + 
        "\n"+ "Custormers Address:" + _customer.GetShippingAddress(); 
    }
}
