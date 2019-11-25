using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleStateDesignPattern
{
    public interface VehicleState
    {
        void move(Vehicle vh, double distance);
        void turnLeft(Vehicle vh);
        void turnRight(Vehicle vh);
        void uTurn(Vehicle vh);
    }
}
