using System;

class Program
{
    static void Main(string[] args)
    {
    // Order 1
    Address address1 = new Address();
    address1.SetAddressValues(new List<string> {"Michael Jordan", "101 Way", "Rexburg", "ID", "USA" });
    
    Customer _customer1 = new Customer();
    _customer1.SetAddressClass(new List<string> {"Michael Jordan", "101 Way", "Rexburg", "ID", "USA" });

    Order order1 = new Order();
    order1.SetCustomer(_customer1);

    Product _product1 = new Product();
    order1.AddProduct(_product1);
    _product1.SetProductInfo("Banana", "A123", 5.99, 2);
    Product _product2 = new Product();
    _product2.SetProductInfo("Grape", "B456", 10.49, 20);
    order1.AddProduct(_product2);
    
    Console.WriteLine("First Order");
    Console.WriteLine("Packing Label:");
    Console.WriteLine(order1.GetPackingLabel());
    Console.WriteLine("\nShipping Label:");
    Console.WriteLine(order1.GetShippingLabel());
    Console.WriteLine("\nTotal Cost:");
    Console.WriteLine($"${order1.ComputeOrderCost()}");

    // Order 2
    Address address2 = new Address();
    address2.SetAddressValues(new List<string> {"Nikola Jokic", "101 Best", "Sombor", "Vojvodina", "Serbia"});
    
    Customer _customer2 = new Customer();
    _customer2.SetAddressClass(new List<string> {"Nikola Jokic", "101 Best", "Sombor", "Vojvodina", "Serbia"});

    Order order2 = new Order();
    order2.SetCustomer(_customer2);

    Product _product3 = new Product();
    order2.AddProduct(_product3);
    _product3.SetProductInfo("Chocolate Milk", "AA1", 7.99, 6);
    Product _product4 = new Product();
    _product4.SetProductInfo("Cookies", "BB2", 9.99, 2);
    order2.AddProduct(_product4);
    
    Console.WriteLine("\nSecond Order");
    Console.WriteLine("Packing Label:");
    Console.WriteLine(order2.GetPackingLabel());
    Console.WriteLine("\nShipping Label:");
    Console.WriteLine(order2.GetShippingLabel());
    Console.WriteLine("\nTotal Cost:");
    Console.WriteLine($"${order2.ComputeOrderCost()}"); 
    }
}