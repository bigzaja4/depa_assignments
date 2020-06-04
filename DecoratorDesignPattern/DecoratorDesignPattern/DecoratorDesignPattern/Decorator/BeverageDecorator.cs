using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Decorator
{
    public abstract class BeverageDecorator : IBeverage
    {
        private IBeverage beverage;

        public BeverageDecorator(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public virtual string Description => beverage.Description;
        public virtual int GetCost() => beverage.GetCost();
    }
}
