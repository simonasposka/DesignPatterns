using DesignPatterns.AbstractFactory.UI;

namespace DesignPatterns.AbstractFactory.Factories
{
    public class DarkThemeFactory : AbstractUIFactory
    {
        public DarkThemeFactory()
        {
        }

        public override UIElement CreateButton(string label)
        {
            return new LightButton(label);
        }

        public override UIElement CreateModal()
        {
            return new DarkModal();
        }
    }
}

