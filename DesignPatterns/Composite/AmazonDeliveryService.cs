namespace DesignPatterns.Composite;

public class AmazonDeliveryService
{
    private Box Box { get; set; }

    public void SetupOrder(Box box)
    {
        Box = new CompositeBox(box);
    }

    public int CalculateOrderPrice()
    {
        return Box.CalculatePrice();
    }
}