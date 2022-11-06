using DesignPatterns.AbstractFactory.UI;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class LightThemeFactory: AbstractUIFactory
    {
        public LightThemeFactory()
        {
        }

        public override UIElement CreateButton(string label)
        {
            return new DarkButton(label);
        }

        public override UIElement CreateModal()
        {
            return new LightModal();
        }
    }
}

