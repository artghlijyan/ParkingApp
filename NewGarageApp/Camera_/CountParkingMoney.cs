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
        public CountParkingMoney() { }
        public int Price
        {
            get
            {
                return ((Camera.Exit - Camera.Entrance).Hours + 1) * 100;
            }
        }

        public void Paid()
        {
            Console.WriteLine("Which country money would you like to pay?\n1.AMD\n2.USD\n3.RUB");
            int countryMoney = int.Parse(Console.ReadLine());

            switch (countryMoney)
            {
                case (int)ChangeMoney.AMD:
                    Console.WriteLine($"You must pay {Price} AMD");
                    break;
                case (int)ChangeMoney.USD:
                    Console.WriteLine($"You must pay " + string.Format("{0:C}", Price / 487.5) + " USD");
                    break;
                case (int)ChangeMoney.RUB:
                    Console.WriteLine($"You must pay " + string.Format("{0:F2}", Price / 7.4) + " RUB");
                    break;
                default:
                    break;
            }
        }
    }
}
