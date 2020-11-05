using System;

namespace NewGarageApp.Vehicles
{
    class Car : Vehicle
    {
        public string brand;
        public string licenseNumber;
        public string color;
        public static DateTime Entrance;
        public static DateTime Exit;

        public Car(string brand, string licenseNumber, string color, DateTime entrance, DateTime exit)
        {
            this.brand = brand;
            this.licenseNumber = licenseNumber;
            this.color = color;
            Entrance = entrance;
            Exit = exit;
        }

        public Car() { }

        public override string ToString()
        {
            return
                   $"Car's brand  {brand}\n" +
                   $"Car's license number  {licenseNumber}\n" +
                   $"Car's color {color}\n" +
                   $"Car entrance at  {Entrance}\n" +
                   $"Car exit at  {Exit}\n";
        }
    }
}
