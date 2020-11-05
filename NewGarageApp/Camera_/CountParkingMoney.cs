using System;

namespace NewGarageApp.Camera_
{

    enum ChangeMoney
    {
        AMD = 1,
        USD,
        RUB
    }

    class CountParkingMoney
    {
        ChangeMoney ChangeMoney;

        public CountParkingMoney(ChangeMoney money)
        {
            ChangeMoney = money;
        }
        public CountParkingMoney()
        {

        }
        public int Price
        {
            get
            {
                return ((Camera.Exit - Camera.Entrance).Hours + 1) * 100;
            }
        }

        public void Paid()
        {
            CountParkingMoney countMoney = new CountParkingMoney();
            Console.WriteLine("Which country money would you like to pay?\n1.AMD\n2.USD\n3.RUB");
            int countryMoney = int.Parse(Console.ReadLine());

            switch (countryMoney)
            {
                case (int)ChangeMoney.AMD:
                    Console.WriteLine($"You must pay {Price} AMD");
                    break;
                case (int)ChangeMoney.USD:
                    Console.WriteLine($"You must pay {(Price * 485.7) / 100} USD");
                    break;
                case (int)ChangeMoney.RUB:
                    Console.WriteLine($"You must pay {(Price * 7.4) / 10} RUB");
                    break;
                default:
                    break;
            }
        }
    }
}
