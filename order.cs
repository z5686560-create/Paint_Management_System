public class Order
{
    private readonly DateTime CreatedAt;
    
    public PaintProduct Product { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }

    public Order(PaintProduct product, int quantity)
    {
        Product = product;
        Quantity = quantity;
        CreatedAt = DateTime.Now;

        TotalPrice = Product.GetFinalPrice() * Quantity;
    }

    public void DisplayOrder()
    {
        Console.WriteLine("===== ORDER =====");
        Console.WriteLine($"Created At: {CreatedAt}");
        Console.WriteLine($"Product: {Product.Name}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Total Price: {TotalPrice}");
    }

    public decimal GetTotalPrice()
    {
        return TotalPrice;
    }
}