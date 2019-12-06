using ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern.Services
{
    class Customer : ICustomer
    {
        public string name { get; set; }
       
        public Customer(string name)
        {
            this.name = name;
        }
        public void Notify(string message)
        {
            Console.WriteLine(name + " receive Noti: " +message+ " change");
        }
    }
}
