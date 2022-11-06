namespace DesignPatterns.Decorator.Beverages
{
    public class Tea : Beverage
    {
        public Tea()
        {
        }

        public override int GetCost()
        {
            return 2;
        }

        public override string GetDescription()
        {
            return "Tea";
        }
    }
}

