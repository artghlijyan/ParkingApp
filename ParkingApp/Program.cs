using System;
using ParkingApp.Backend;

namespace ParkingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking parking = new MashtotsParking();
            Car car = new Car()
            {
                brand = "Audi",
                licenseNumber = "00AA000"
            };

            int row = int.Parse(Console.ReadLine());
            int colume = int.Parse(Console.ReadLine());

            parking.ParkTable();
            Check check = parking.Enter(car, row, colume);
            Console.WriteLine(check.carDetails);
            parking.ParkTable();

            Console.WriteLine(".....................");

            Parking parking1 = new AmiryanParkin();
            parking1.ParkTable();

            int row1 = int.Parse(Console.ReadLine());
            int colume2 = int.Parse(Console.ReadLine());

            Check check1 = parking1.Enter(car, row1, colume2);
            Console.WriteLine(check1.carDetails);

            parking1.ParkTable();
        }
    }
}
