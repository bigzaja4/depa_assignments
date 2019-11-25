namespace VehicleStateDesignPattern
{
    class East : VehicleState
    {
        private readonly static East east = new East();
        
        private East() { }
        public static East GetEast()
        {
            return east;
        }
        public void move(Vehicle vh, double distance)
        {
            vh.SetX(vh.GetX() + distance);
        }

        public void turnLeft(Vehicle vh)
        {
            vh.SetDirection(North.GetNorth());
        }

        public void turnRight(Vehicle vh)
        {
            vh.SetDirection(South.GetSouth());
        }

        public void uTurn(Vehicle vh)
        {
            vh.SetDirection(West.GetWest());
        }
        public override string ToString()
        {
            return "East";
        }
    }
}