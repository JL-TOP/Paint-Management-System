using System;

namespace PaintManagementSystem;

public class PaintSotre
{
    public PaintProduct[] Products { get; }

    public PaintSotre (PaintProduct[] products)
    {
        Products = products;
    }
}
