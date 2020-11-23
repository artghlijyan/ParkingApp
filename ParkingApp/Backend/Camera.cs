using System;
using System.Collections.Generic;

namespace ParkingApp.Backend
{
    public class Camera
    {
        public Car car;
        public DateTime enterDate;

        public Check CaptureCar(Car car)
        {
            return new Check()
            {
                carDetails = car.brand + ", " + car.licenseNumber,
                enterDate = DateTime.Now.ToString()
            };
        }
    }
}