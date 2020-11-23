using System;

namespace ParkingApp.Backend
{
    public class Terminal
    {
        PaymentCounter paymentCounter;

        public Check GiveCheck(Check check, int row, int column)
        {
            check.place = " Place: " + row + ", " + column;
            return check;
        }

        public void RecieveCheck(Check check)
        {
            
        }
    }
}