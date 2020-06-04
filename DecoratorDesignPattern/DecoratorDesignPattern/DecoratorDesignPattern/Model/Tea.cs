using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern
{
    public class Tea : IBeverage
    {
        public string Description => "Relaxing Tea";

        public int GetCost()
        {
            return 35;
        }
    }
}
