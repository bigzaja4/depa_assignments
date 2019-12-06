using ObserverDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverDesignPattern.Services
{
    class Product : IProduct
    {
        private List<ICustomer> subsciber;
        private double price { get; set; }
        private string name { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
            this.subsciber = new List<ICustomer>();
        }

        public void Disinterest(ICustomer customer)
        {
            var removeItem = subsciber.SingleOrDefault(i => i == customer);
            if(removeItem != null)
            {
                subsciber.Remove(removeItem);
            }
        }

        public void InterestIn(ICustomer customer)
        {
            subsciber.Add(customer);
        }

        public void GetAllSubsciber()
        {
            foreach(Customer customer in subsciber)
            {
                Console.WriteLine("Name: "+ customer.name);
            }
        }

        private void Notify(string message)
        {
            foreach(Customer customer in subsciber)
            {
                customer.Notify(message);
            }
        }

        public void SetPrice(double price)
        {
            this.price = price;
            Notify("Product Price");
        }

        public double GetPrice()
        {
            return this.price;
        }

        public void SetName(string name)
        {
            this.name = name;
            Notify("Product Name");
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
