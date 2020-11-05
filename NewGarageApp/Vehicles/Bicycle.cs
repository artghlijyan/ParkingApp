using System;

namespace NewGarageApp.Vehicles
{
    class Bicycle : Vehicle
    {
        private int passengers;
        private int MaxPassengers { get; set; }

        public Bicycle(int price, int maxSpeed, int productionYear, int passenger) : base(price, maxSpeed, productionYear)
        {
            passengers = passenger;
        }


        public int GetCurrentPassengers()
        {
            return passengers;
        }

        public void SetCurrentPassengers(int n)
        {
            if (n > MaxPassengers)
            {
                throw new Exception("The bicycle can't move so many passengers");
            }
            else if (n < 0)
            {
                Console.WriteLine("There is nobody on bicycle");
            }
            passengers = n;
        }
    }
}
