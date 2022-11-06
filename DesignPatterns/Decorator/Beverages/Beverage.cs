using System;
namespace DesignPatterns.Decorator.Beverages
{
    public abstract class Beverage
    {
        public Beverage()
        {
        }

        public abstract string GetDescription();
        public abstract int GetCost();

        public override string ToString()
        {
            return $"description: {GetDescription()}, cost: {GetCost()}";
        }
    }
}

