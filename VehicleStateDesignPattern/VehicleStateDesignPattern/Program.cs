using System;

namespace VehicleStateDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vehicle vehicle = new Vehicle();

            vehicle.getCurrentLocation();
            vehicle.GetDirection();

            vehicle.TurnLeft();
            vehicle.Move(13.5);
            vehicle.GetDirection();

            vehicle.TurnLeft();
            vehicle.GetDirection();

            vehicle.TurnLeft();
            vehicle.Move(30.5);
            vehicle.GetDirection();

            vehicle.UTurn();
            vehicle.Move(7.9);
            vehicle.GetDirection();

            vehicle.TurnRight();
            vehicle.Move(25.2);
            vehicle.GetDirection();

            vehicle.UTurn();
            vehicle.GetDirection();

            vehicle.getCurrentLocation();

        }
    }
}
