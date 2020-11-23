using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingApp.Backend
{
    class MashtotsParking : Parking
    {
        public MashtotsParking()
        {
            base.ParkMap = new int[4, 5];
            base.Space = ParkMap.Length;
            base.FreeSpace = default;
        }

        

        public void ShowFreeSpace()
        {

        }
    }
}
