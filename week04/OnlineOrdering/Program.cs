using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Online Ordering Program ---");

        // --- Order 1: USA Customer ---
        Console.WriteLine("\n===== Order 1 =====");

        // Create Address 1 (USA)
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        // Create Customer 1
        Customer customer1 = new Customer("John Doe", address1);

        // Create Products for Order 1
        Product product1_1 = new Product("Laptop", "LAP101", 1200.00, 1);
        Product product1_2 = new Product("Mouse", "ACC001", 25.50, 2);

        // Create Order 1
        Order order1 = new Order(customer1);
        order1.AddProduct(product1_1);
        order1.AddProduct(product1_2);

        // Display details for Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Order 1 Total Cost: ${order1.CalculateTotalCost():F2}"); // :F2 formats to 2 decimal places

        // --- Order 2: International Customer ---
        Console.WriteLine("\n===== Order 2 =====");

        // Create Address 2 (International)
        Address address2 = new Address("45 Oxford St", "London", "Greater London", "United Kingdom");
        // Create Customer 2
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create Products for Order 2
        Product product2_1 = new Product("Keyboard", "ACC002", 75.00, 1);
        Product product2_2 = new Product("Monitor", "MON201", 300.00, 1);
        Product product2_3 = new Product("Webcam", "ACC003", 45.99, 3);


        // Create Order 2
        Order order2 = new Order(customer2);
        order2.AddProduct(product2_1);
        order2.AddProduct(product2_2);
        order2.AddProduct(product2_3);

        // Display details for Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Order 2 Total Cost: ${order2.CalculateTotalCost():F2}");

        Console.WriteLine("\n--- Program End ---");
    }
}