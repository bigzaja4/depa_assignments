using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Interfaces
{
    interface ICustomer
    {
        void Notify(string message);
    }
}
