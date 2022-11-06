using DesignPatterns.Decorator.Beverages;

namespace DesignPatterns.Decorator.Decorators
{
    public class CaramelDecorator : BaseDecorator
    {
        protected Beverage beverage;

        public CaramelDecorator(Beverage b)
        {
            beverage = b;
        }

        public override int GetCost()
        {
            return beverage.GetCost() + 2;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", with caramel";
        }
    }
}

