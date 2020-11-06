using System;

namespace NewGarageApp.Vehicles
{
    class Car : Vehicle
    {
        public string brand;
        public string licenseNumber;
        public string color;        

        public Car(string brand, string licenseNumber, string color)
        {
            this.brand = brand;
            this.licenseNumber = licenseNumber;
            this.color = color;           
        }

        public Car() { }

        public override string ToString()
        {
            return
                   $"Car's brand  {brand}\n" +
                   $"Car's license number  {licenseNumber}\n" +
                   $"Car's color {color}\n";
                  
        }
    }
}
