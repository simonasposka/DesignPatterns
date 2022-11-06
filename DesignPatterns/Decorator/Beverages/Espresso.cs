namespace DesignPatterns.Decorator.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
        }

        public override int GetCost()
        {
            return 1;
        }

        public override string GetDescription()
        {
            return "Espresso";
        }
    }
}

