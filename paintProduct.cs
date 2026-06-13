public class PaintProduct : IBuyable
{
    private readonly decimal TaxRate;
    private const decimal DefaultDiscount = 0.05m;

    public string Name { get; set; }
    public PaintType Type { get; set; }
    public PaintSpecification Specification { get; set; }
    public decimal Price { get; set; }

    public PaintProduct(string name, PaintType type,
        PaintSpecification spec, decimal price, decimal taxRate = 0.10m)
    {
        Name = name;
        Type = type;
        Specification = spec;
        Price = price;
        TaxRate = taxRate;
    }

    public decimal GetFinalPrice()
    {
        decimal discounted = Price * (1 - DefaultDiscount);
        decimal taxed = discounted * (1 + TaxRate);
        return taxed;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name:{Name}");
        Console.WriteLine($"Type:{Type}");
        Console.WriteLine($"Price:{Price}");
        Specification.DisplaySpecification();
        Console.WriteLine($"Final Price:{GetFinalPrice()}");

    }

    public decimal GetMaxDiscount(int rate, bool Overridable)
    {
        if (Overridable)
        {
            return rate / 100m;
        }

        return DefaultDiscount;
    }

}