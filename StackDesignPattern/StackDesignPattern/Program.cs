using System;

namespace StackDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            bt.add("Hello");
            bt.add("Jaylato");
            bt.add("Sumo");
            bt.add("Angular");
            bt.add("React");

            //bt.add("BAC");
            //bt.add("ABC");
            //bt.add("DEF");
            //bt.add("CDG");

            bt.printNode();
        }
    }
}
