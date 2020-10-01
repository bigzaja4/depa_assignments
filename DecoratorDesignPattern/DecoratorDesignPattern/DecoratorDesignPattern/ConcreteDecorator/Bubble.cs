using DecoratorDesignPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.ConcreteDecorator
{
    public class Bubble : BeverageDecorator
    {
        private readonly int topUpPrice = 5;
        public string Size { get; }
        public int SizeTopUpPrice { get; set; }
        public override string Description => base.Description+$" + {Size} size Bubble";

        public override int GetCost()
        {
            SizeTopUpPrice = 0;
            switch(this.Size) 
            {
                case "S": SizeTopUpPrice = 5; break;
                case "M": SizeTopUpPrice = 10; break;
                case "L": SizeTopUpPrice = 15; break;
            }
            this.SizeTopUpPrice = 5;
            return base.GetCost()+topUpPrice+SizeTopUpPrice;
        }

        public Bubble(IBeverage beverage, Size size) : base(beverage) 
        {
            this.Size = size.ToString();
        }
    }

    public enum Size
    {
        S,
        M,
        L
    }
}
