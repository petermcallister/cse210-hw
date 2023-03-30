using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        List<Product> products1 = new List<Product>()
        {
            new Product("Product1", 1, 10.0, 2),
            new Product("Product2", 2, 20.0, 1)
        };
        Order order1 = new Order(products1, customer1);
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total cost: {order1.GetTotalCost()}");

        Console.WriteLine();

        Address address2 = new Address("456 Main St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        List<Product> products2 = new List<Product>()
        {
            new Product("Product3", 3, 15.0, 3),
            new Product("Product4", 4, 30.0, 1),
            new Product("Product5", 5, 5.0, 5)
        };
        Order order2 = new Order(products2, customer2);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total cost: {order2.GetTotalCost()}");

        Console.ReadLine();
    }
}
