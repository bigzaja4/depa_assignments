using ObserverDesignPattern.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Interfaces
{
    interface IProduct
    {
        void InterestIn(ICustomer customer);
        void Disinterest(ICustomer customer);
    }
}
