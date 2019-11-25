using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStateDesignPattern
{
    public class North : VehicleState
    {
        private readonly  static North north = new North();
        private North() { }

        public static North GetNorth()
        {
            return north;
        }
        public void move(Vehicle vh, double distance)
        {
            vh.SetY(vh.GetY() + distance);
        }

        public void turnLeft(Vehicle vh)
        {
            vh.SetDirection(West.GetWest());
        }

        public void turnRight(Vehicle vh)
        {
            vh.SetDirection(East.GetEast());
        }

        public void uTurn(Vehicle vh)
        {
            vh.SetDirection(South.GetSouth());
        }
        public override string ToString()
        {
            return "North";
        }
    }
}
