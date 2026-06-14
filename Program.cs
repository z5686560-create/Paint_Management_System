class Program
{
    static void Main()
    {
        PaintSpecification spec1 = new PaintSpecification("Red", 10);
        PaintSpecification spec2 = new PaintSpecification("Blue", 5);

        PaintProduct paint1 = new PaintProduct("Dulux Base", PaintType.BaseCoat, spec1, 100);
        PaintProduct paint2 = new PaintProduct("Dulux Gloss", PaintType.Glossy, spec2, 150);

        paint1.DisplayInfo();
        Console.WriteLine();
        paint2.DisplayInfo();

        Order order = new Order(paint1, 2);
        order.DisplayOrder();
    }
}
