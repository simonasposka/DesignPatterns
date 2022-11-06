using DesignPatterns.AbstractFactory.UI;

namespace DesignPatterns.AbstractFactory.Factories
{
    public abstract class AbstractUIFactory
    {
        public AbstractUIFactory(){}
        public abstract UIElement CreateButton(string label);
        public abstract UIElement CreateModal();
    }
}

