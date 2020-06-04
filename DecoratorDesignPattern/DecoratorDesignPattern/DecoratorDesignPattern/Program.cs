using DecoratorDesignPattern.ConcreteDecorator;
using System;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Beverage!!!");
            Console.WriteLine("*************************");

            var coffee = new Coffee();
            Console.WriteLine("Original Coffee");
            Console.WriteLine($"{ coffee.Description}, Price:{coffee.GetCost()}\n");

            IBeverage coffeeWithWhipCream = new WhipCream(coffee);
            Console.WriteLine("Extra Coffee with WhipCream");
            Console.WriteLine($"{ coffeeWithWhipCream.Description}, Price:{coffeeWithWhipCream.GetCost()}\n");

            var tea = new Tea();
            Console.WriteLine("Original Tea");
            Console.WriteLine($"{ tea.Description}, Price:{tea.GetCost()}\n");


            IBeverage extraTea = new WhipCream(tea);
            extraTea = new Bubble(extraTea,Size.M);
            Console.WriteLine("Extra tea with WhipCream and Bubble");
            Console.WriteLine($"{ extraTea.Description}, Price:{extraTea.GetCost()}\n");

        }
    }
}
