namespace DesignPatterns.AbstractFactory.UI
{
    public class LightButton : UIElement
    {
        public string Color { get; set; } = "White";
        public string Label { get; set; }

        public LightButton(string label)
        {
            Label = label;
        }
    }
}

