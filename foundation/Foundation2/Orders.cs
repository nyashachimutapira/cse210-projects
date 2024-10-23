using System.Collections.Generic;

/// <summary>
/// Represents an order containing products and a customer.
/// </summary>
public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private const decimal DomesticShippingCost = 5.00m;
    private const decimal InternationalShippingCost = 35.00m;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    /// <summary>
    /// Adds a product to the order.
    /// </summary>
    /// <param name="product">The product to add.</param>
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    /// <summary>
    /// Calculates the total price of the order including shipping.
    /// </summary>
    /// <returns>Total price of the order.</returns>
    public decimal CalculateTotalPrice()
    {
        decimal totalCost = 0;

        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        decimal shippingCost = _customer.IsInUSA() ? DomesticShippingCost : InternationalShippingCost;
        return totalCost + shippingCost;
    }

    /// <summary>
    /// Returns the packing label for the order.
    /// </summary>
    /// <returns>Packing label as a string.</returns>
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    /// <summary>
    /// Returns the shipping label for the order.
    /// </summary>
    /// <returns>Shipping label as a string.</returns>
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.Name}\n{_customer.Address}";
    }
}