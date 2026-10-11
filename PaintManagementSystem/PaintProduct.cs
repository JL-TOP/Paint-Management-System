using System;

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
        
    }

    public void DispalyInfo()
    {
        
    }

    public void GetMaxDiscount (int rate)
    {
        
    }

}
