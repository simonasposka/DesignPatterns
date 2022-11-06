using DesignPatterns.Decorator.Beverages;

namespace DesignPatterns.Decorator.Decorators
{
    public class SoyMilkDecorator : BaseDecorator
    {
        protected Beverage beverage;

        public SoyMilkDecorator(Beverage b)
        {
            beverage = b;
        }

        public override int GetCost()
        {
            return beverage.GetCost() + 1;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", with soy milk";
        }
    }
}

