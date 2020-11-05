namespace NewGarageApp.Park
{
    class SpaceForPark
    {
        private int parkingLength = 5;
        private int parkingWidth = 3;

        public SpaceForPark()
        {
            AllPark.busySpaceCount++;
        }

        public override string ToString()
        {
            return $"Parking space length = {parkingLength} metr\n" +
                   $"Parking space width = {parkingWidth} metr\n";
        }
    }
}
