using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    public class Coffee : IBeverage
    {
        public string Description { get => "Good taste Coffee"; }

        public int GetCost()
        {
            return 40;
        }
    }
}
