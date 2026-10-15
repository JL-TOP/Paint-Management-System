using System.Runtime.Intrinsics.X86;

namespace PaintManagementSystem;

public class Program
{
    static void Main(string[] args)
    {
        PaintSpecification paint1 = new ("gray", 20);
        PaintSpecification paint2 = new ("white", 30);
        PaintSpecification paint3 = new ("Green", 40);

        PaintProduct good1 = new ("adx", PaintType.BaseCoat, paint1, 50);
        PaintProduct good2 = new ("adx", PaintType.Glossy, paint2, 70);
        PaintProduct good3 = new ("adx", PaintType.Matte, paint3, 90);

        Console.WriteLine("Display Product:");
        good1.DisplayInfo();
        good2.DisplayInfo();
        good3.DisplayInfo();

        Order paintOrder  = new (good1, 5);

        Console.WriteLine();
        Console.WriteLine("Display Order:");
        paintOrder.DisplayOrder();
    }
}