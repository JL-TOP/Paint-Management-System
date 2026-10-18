using System.Runtime.Intrinsics.X86;

namespace PaintManagementSystem;

public class Program
{
    static void Main(string[] args)
    {
        PaintSpecification paint1 = new ("gray", 20);
        PaintSpecification paint2 = new ("white", 30);
        PaintSpecification paint3 = new ("Green", 40);

        PaintProduct product1 = new ("window", PaintType.BaseCoat, paint1, 50);
        PaintProduct product2 = new ("celling", PaintType.Glossy, paint2, 70);
        PaintProduct product3 = new ("wall", PaintType.Matte, paint3, 90);

        PaintProduct[] PaintProducts = {product1, product2, product3};

        Console.WriteLine($"Paints In Sotre: ");
        Console.WriteLine();
        foreach (PaintProduct product in PaintProducts)
        {
            product.DisplayInfo();
            Console.WriteLine();
        }

        Order order1  = new (product1, 5);
        Order order2  = new (product2, 3);
        Order order3  = new (product3, 8);

       
        Console.WriteLine();
        Console.WriteLine("Display Order:");
        order1.DisplayOrder();
        Console.WriteLine();


        Console.WriteLine("Multipul Product Order: ");
        int[] Quantities = {5, 3, 8};
        Order order = new (PaintProducts, Quantities);

        order.GetTotalOrderPrice();
    }
}