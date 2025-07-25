using System;
using System.Collections.Generic; // Required for List<T>
using System.Linq; // Required for Sum() and other LINQ methods (optional, but helpful)

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>(); // Initialize the list of products
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalProductsCost = 0;
        foreach (Product product in _products)
        {
            totalProductsCost += product.GetTotalCost(); // Get each product's cost
        }

        // Determine shipping cost
        double shippingCost = _customer.IsInUSA() ? 5.00 : 35.00;

        return totalProductsCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "--- Packing Label ---\n";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "--- Shipping Label ---\n";
        label += $"Customer Name: {_customer.GetName()}\n";
        label += $"Customer Address:\n{_customer.GetAddress().GetFullAddressString()}";
        return label;
    }
}