using System;
using System.Runtime.CompilerServices;

namespace PaintManagementSystem;

public class Order
{
    public  DateTime CreatedAt { get; }
    public PaintProduct Product { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }

    public Order(PaintProduct product, int quantity)
    {
        CreatedAt = DateTime.Now;
        Product = product;
        Quantity = quantity;
        TotalPrice = Quantity * Product.GetFinalPrice();
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Product: {Product.Name} {Product.Type}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Order created at: {CreatedAt}");
    }

    public void GetTotalPrice()
    {
        Console.WriteLine($"Total price: {TotalPrice}");
    }

    public decimal GetTotalOrderPrice()
    {
        
        decimal totalOrderPrice = 10;
        return  totalOrderPrice;
    }
}
