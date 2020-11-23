namespace NewGarageApp.Park
{
    class ParkSpace
    {
        private int parkingLength = 5;
        private int parkingWidth = 3;

        public ParkSpace()
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
