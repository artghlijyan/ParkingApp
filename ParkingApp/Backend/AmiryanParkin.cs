using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingApp.Backend
{
    class AmiryanParkin : Parking
    {
        public AmiryanParkin()
        {
            base.ParkMap = new int[3, 4];
            base.Space = ParkMap.Length;
            base.FreeSpace = default;
        }
    }
}
