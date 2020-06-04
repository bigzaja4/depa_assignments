using DecoratorDesignPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.ConcreteDecorator
{
    public class WhipCream : BeverageDecorator
    {
        private readonly int topUpPrice = 10;
        public override string Description => base.Description+" + Whip Cream";
        public override int GetCost()
        {
            return base.GetCost() + topUpPrice;
        }

        public WhipCream(IBeverage beverage) : base(beverage) { }
    }
}