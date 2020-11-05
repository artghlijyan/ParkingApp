using NewGarageApp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGarageApp.Camera_
{
    class Camera
    {
        private readonly string brand;
        private readonly string licenseNumber;
        private readonly string color;
        public static DateTime Entrance;
        public static DateTime Exit;

        public Camera(string brand, string licenseNumber, string color, DateTime entrance, DateTime exit)
        {
            this.brand = brand;
            this.licenseNumber = licenseNumber;
            this.color = color;
            Entrance = entrance;
            Exit = exit;
        }

        public Camera() { }

        public override string ToString()
        {
            return
                   $"Car's brand  {brand}\n" +
                   $"Car's license number  {licenseNumber}\n" +
                   $"Car's color {color}\n" +
                   $"Car entrance at  {Entrance}\n" +
                   $"Car exit at  {Exit}\n";
        }

        public void Match(Car car, Camera camera)
        {
            if (car == camera)
            {
                Console.WriteLine("-----The car can enter-----\n");
            }
            else
            {
                throw new Exception("The car does't match");
            }
        }


        public static bool operator ==(Car car, Camera camera)
        {
            return car.brand == camera.brand &&
                   car.licenseNumber == camera.licenseNumber &&
                   car.color == camera.color &&
                   Car.Entrance == Camera.Entrance &&
                   Car.Exit == Camera.Exit;
        }

        public static bool operator !=(Car car, Camera camera)
        {
            return car.brand != camera.brand ||
                   car.licenseNumber != camera.licenseNumber ||
                   car.color != camera.color &&
                   Car.Entrance == Camera.Entrance &&
                   Car.Exit == Camera.Exit; ;
        }
    }
}
