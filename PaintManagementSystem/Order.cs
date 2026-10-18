using System;
using System.Runtime.CompilerServices;

namespace PaintManagementSystem;

public class Order
{
    public  DateTime CreatedAt { get; }
    public PaintProduct? Product { get; set;}   // *****
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }

    public PaintProduct[]? Items { get; set; }
    public int[]? Quantities { get; set; }


    public Order(PaintProduct product, int quantity)
    {
        CreatedAt = DateTime.Now;
        Product = product;
        Quantity = quantity;
        TotalPrice = Quantity * Product.GetFinalPrice();
    }

    public Order(PaintProduct[] items, int[] quantities)    //Overloading Order Constructor
    {
        Items = items;
        Quantities = quantities;
    }

    public void DisplayOrder()
    {
        if (Product != null)
        {
            Console.WriteLine($"Product: {Product.Name} {Product.Type}");
            Console.WriteLine($"Quantity: {Quantity}");
        }
        Console.WriteLine($"Order created at: {CreatedAt}");
    }

    public void GetTotalPrice()
    {
        Console.WriteLine($"Total price: {TotalPrice}");
    }

    public void GetTotalOrderPrice()
    {
        
        decimal totalOrderPrice = 0;
        if (Items != null && Quantities != null)
        {
            
            for (int i = 0; i < Items.Length; i++)
            {
                totalOrderPrice += totalOrderPrice;
                for (int j = 0; j < Items.Length; j++)
                {
                    totalOrderPrice = Items[i].Price * Quantities[i]; 
                }
            }
        }

        Console.WriteLine($"{totalOrderPrice}");
        
    }
}
