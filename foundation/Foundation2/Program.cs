// Author: Holly Briggs, 10/4/2023
// Week 04 CSE 210 prove 2 assignment

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an order and customer and the product objects for first order. Populate their attributes with values.
        Address address1 = new Address();
        address1.SetAddress("41 West 800 South", "Orem", "Utah", "USA");
        Customer customer1 = new Customer();
        customer1.SetCustomerName("Holly Briggs");
        Order order1 = new Order(customer1);
        customer1.SetCustomerAddress(address1);
        Product product1a = new Product("Milk", 001245, 3.45, 1);
        Product product1b = new Product("Organic Flax Seeds", 083452, 5.75, 5);
        Product product1c = new Product("Oats", 045632, 4.25, 1);
        order1.StoreProduct(product1a);
        order1.StoreProduct(product1b);
        order1.StoreProduct(product1c);

        // Call and Print to the Console the Packing Label and the shipping label and the total price of the order.

        string packingLabel = order1.GetPackingLabel();
        string shippingLabel = order1.GetShippingLabel();

        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(packingLabel);
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(shippingLabel);
        Console.WriteLine($"Total Cost: {order1.TotalCost()}");

        Console.WriteLine();

        // Create an order and customer and the product objects for second order. Populate their attributes with values.
        Address address2 = new Address();
        address2.SetAddress("123 Maple Lane", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer();
        customer2.SetCustomerName("Eliza Brubaker");
        Order order2 = new Order(customer2);
        customer2.SetCustomerAddress(address2);
        Product product2a = new Product("Stawberries", 065432, 4.99, 2);
        Product product2b = new Product("Pickles", 096442, 3.65, 1);
        Product product2c = new Product("Honey", 042568, 7.95, 1);
        order2.StoreProduct(product2a);
        order2.StoreProduct(product2b);
        order2.StoreProduct(product2c);

        // Call and Print to the Console the Packing Label and the shipping label and the total price of the order.

        string packingLabel2 = order2.GetPackingLabel();
        string shippingLabel2 = order2.GetShippingLabel();

        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(packingLabel2);
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(shippingLabel2);
        Console.WriteLine($"Total Cost: {order2.TotalCost()}");      
        
    }
}