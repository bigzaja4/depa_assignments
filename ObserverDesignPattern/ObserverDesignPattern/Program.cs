using ObserverDesignPattern.Services;
using System;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Somchai");
            Customer c2 = new Customer("Sommai");
            Customer c3 = new Customer("Somsri");

            Product product = new Product("Lays", 20 );
            product.InterestIn(c1);
            product.InterestIn(c2);
            product.InterestIn(c3);

            product.SetPrice(30);

            product.Disinterest(c2);

            Console.WriteLine("---------------");

            product.Disinterest(c2);
            product.SetName("Layss");


        }
    }
}
