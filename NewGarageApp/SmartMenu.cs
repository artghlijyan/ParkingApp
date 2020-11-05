using NewGarageApp.Camera_;
using NewGarageApp.Park;
using NewGarageApp.Vehicles;
using System;

namespace NewGarageApp
{
    class SmartMenu
    {
        private static AllPark park;

        private static Camera camera;

        private static Car car;


        public void Table()
        {
            Menu();
            Console.Write("Please enter the row ");
            int row = int.Parse(Console.ReadLine());
            Console.Write($"Please enter the column ");
            int column = int.Parse(Console.ReadLine());
            park[row, column] = new SpaceForPark();
            AllPark.ParkTable();
        }

        public static void Camera(string brand, string licenseNumber, string color, DateTime entrance, DateTime exit)
        {
            camera = new Camera(brand, licenseNumber, color, entrance, exit);
            if (car == camera)
            {
                Console.WriteLine(camera);
            }
            else
            {
                throw new Exception("The car does't match");
            }
        }

        public static void Terminal()
        {
            CountParkingMoney parkingMoney = new CountParkingMoney();
            parkingMoney.Paid();
            Console.WriteLine("Good Luck!");

        }

        public static void Menu()
        {
            Console.Clear();
            camera.Match(car, camera);
            Console.WriteLine("Please enter \"Yes\" if you want to see the park otherwise \"No\"");

            string answer = Console.ReadLine();

            switch (answer)
            {
                case "Yes":
                    AllPark.ParkTable();
                    park = new AllPark();
                    Console.WriteLine(park);
                    break;
                default:
                    park = new AllPark();
                    Console.WriteLine(park);
                    break;
            }
        }

        public static void EnterYourCarData()
        {
            Console.WriteLine("Please enter your car brand ");
            string brand = Console.ReadLine();
            Console.WriteLine("Please enter your car license number ");
            string license = Console.ReadLine();
            Console.WriteLine("Please enter your car color ");
            string color = Console.ReadLine();
            Console.WriteLine("Please enter entrence time");
            DateTime entrenceTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Please enter exit time");
            DateTime exitTime = DateTime.Parse(Console.ReadLine());
            car = new Car(brand, license, color, entrenceTime, exitTime);
        }
    }
}
