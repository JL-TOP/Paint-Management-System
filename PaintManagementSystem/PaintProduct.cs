using System;
using System.Runtime.CompilerServices;

namespace PaintManagementSystem;

public class PaintProduct : IBuyable
{
    public readonly decimal TaxRate;
    public const decimal discount = 0.05m;
    public string Name { get; set; }
    public PaintType Type { get; set; }
    public PaintSpecification  Specification { get; set; }
    public decimal Price { get; set; }

    public PaintProduct (string name, PaintType type, PaintSpecification specification, decimal price)
    {
        Name = name;
        Type = type;
        Specification = specification;
        Price = price;
        TaxRate = 0.1m;
    }

    public decimal GetFinalPrice ()
    {
        decimal finalPrice = Price * (1 - discount) * (1 + TaxRate);
        
        return finalPrice;
    }

    public void DispalyInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Specificatioin: {Specification}");
        Console.WriteLine($"Price: ${Price}");
    }

    public void GetMaxDiscount (int rate, bool isOverridable)
    {
        
    }

}
