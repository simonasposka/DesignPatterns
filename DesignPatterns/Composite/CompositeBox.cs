namespace DesignPatterns.Composite;

public class CompositeBox : Box
{
    private Box Child;

    public CompositeBox(Box box)
    {
        Child = box;
    }

    public int CalculatePrice()
    {
        return Child.CalculatePrice();
    }
}