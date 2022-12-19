namespace DesignPatterns.Composite;

public abstract class Product : Box
{
    public string Name { get; set; }
    public int Price { get; set; }
    public abstract int CalculatePrice();
}