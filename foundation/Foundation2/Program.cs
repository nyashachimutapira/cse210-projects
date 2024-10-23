using System;

/// <summary>
/// Entry point for the Online Ordering System program.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        Address address2 = new Address("456 Maple Ave", "Othertown", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 999.99m, 1));
        order1.AddProduct(new Product("Mouse", 102, 19.99m, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Smartphone", 201, 599.99m, 1));
        order2.AddProduct(new Product("Headphones", 202, 89.99m, 1));

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    /// <summary>
    /// Displays the order details including packing label, shipping label, and total price.
    /// </summary>
    /// <param name="order">The order to display.</param>
    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotalPrice():F2}");
        Console.WriteLine(new string('-', 40));
    }
}