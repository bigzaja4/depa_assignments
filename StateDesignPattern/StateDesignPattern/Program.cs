using System;

namespace StateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello State!");
            User user = new User();

            user.hello();

            user.printState();
            user.getIn();

            user.printState();
            user.getIn();

            user.printState();
            user.getIn();
            user.increase();

            user.hello();

            user.printState();
            user.getOut();

            user.printState();
            user.getOut();

            user.printState();
            user.getOut();
        }
    }
}
