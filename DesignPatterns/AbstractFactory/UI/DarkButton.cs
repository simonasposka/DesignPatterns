namespace DesignPatterns.AbstractFactory.UI
{
    public class DarkButton : UIElement
    {
        public string Color { get; set; } = "Black";
        public string Label { get; set; }

        public DarkButton(string label)
        {
            Label = label;
        }
    }
}

