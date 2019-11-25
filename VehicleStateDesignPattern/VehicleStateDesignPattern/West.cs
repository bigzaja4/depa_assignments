namespace VehicleStateDesignPattern
{
    class West : VehicleState
    {
        private readonly static West west = new West();

        private West(){ }

        public static West GetWest()
        {
            return west;
        }

        public void move(Vehicle vh, double distance)
        {
            vh.SetX(vh.GetX() - distance);
        }

        public void turnLeft(Vehicle vh)
        {
            vh.SetDirection(South.GetSouth());
        }

        public void turnRight(Vehicle vh)
        {
            vh.SetDirection(North.GetNorth());
        }

        public void uTurn(Vehicle vh)
        {
            vh.SetDirection(East.GetEast());
        }
        public override string ToString()
        {
            return "West";
        }
    }
}