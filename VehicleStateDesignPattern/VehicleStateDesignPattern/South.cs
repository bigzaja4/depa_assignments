namespace VehicleStateDesignPattern
{
    class South : VehicleState
    {
        private readonly static South south = new South();

        private South() { }

        public static South GetSouth()
        {
            return south;
        }
        public void move(Vehicle vh, double distance)
        {
            vh.SetY(vh.GetY() - distance);
        }

        public void turnLeft(Vehicle vh)
        {
            vh.SetDirection(East.GetEast());
        }

        public void turnRight(Vehicle vh)
        {
            vh.SetDirection(West.GetWest());
        }

        public void uTurn(Vehicle vh)
        {
            vh.SetDirection(North.GetNorth());
        }
        public override string ToString()
        {
            return "South";
        }
    }
}