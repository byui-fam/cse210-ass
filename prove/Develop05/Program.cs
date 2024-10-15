using System;

namespace Foundation1
{
    // Main program class to demonstrate the Video and Comment classes
class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("Laptop", "P001", 1200.00f, 2);
        Product product2 = new Product("Mouse", "P002", 25.50f, 3);
        Product product3 = new Product("Keyboard", "P003", 45.75f, 1);

        // Create a customer with an address
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Create an order and add products to it
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Display packing label, shipping label, and total price for the order
        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}\n");

        // Create another customer and products for a second order
        Address address2 = new Address("456 Elm St", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product4 = new Product("Tablet", "P004", 300.00f, 1);
        Product product5 = new Product("Charger", "P005", 20.00f, 4);

        // Create the second order and add products to it
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display packing label, shipping label, and total price for the second order
        Console.WriteLine("Order 2 Details:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");
    }
}
