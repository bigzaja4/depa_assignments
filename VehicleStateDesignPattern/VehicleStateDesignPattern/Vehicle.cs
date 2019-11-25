using System;

namespace VehicleStateDesignPattern
{
    public class Vehicle
    {
        private double X;
        private double Y;
        private VehicleState Direction;

        public Vehicle()
        {
            this.Direction = North.GetNorth();
        }

        public Vehicle(double x , double y)
        {
            this.X = x;
            this.Y = y;
            this.Direction = North.GetNorth();
        }

        public void getCurrentLocation()
        {
            Console.WriteLine("You are at X: " + this.X + ", Y: " + this.Y);
        }

        public void SetY(double y)
        {
            this.Y = y;
        }
        public double GetY()
        {
            return this.Y;
        }
        public void SetX(double x)
        {
            this.X = x;
        }
        public double GetX()
        {
            return this.X;
        }
        public void SetDirection(VehicleState vehicleState)
        {
            this.Direction = vehicleState;
        }
        public void GetDirection()
        {
            Console.WriteLine("Direction: " +this.Direction);
        }
        public void Move(double distant)
        {
            this.Direction.move(this, distant);
        }
        public void TurnLeft()
        {
            this.Direction.turnLeft(this);
        }
        public void TurnRight()
        {
            this.Direction.turnRight(this);
        }
        public void UTurn()
        {
            this.Direction.uTurn(this);
        }
    }
}