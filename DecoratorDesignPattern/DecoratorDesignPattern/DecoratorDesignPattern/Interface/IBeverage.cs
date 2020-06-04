using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    public interface IBeverage
    {
        string Description { get; }

        public int GetCost();
    }
}