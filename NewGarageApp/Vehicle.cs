using System;

namespace NewGarageApp
{
    class Vehicle
    {
        private int price;
        private int maxSpeed;
        private int productionYear;

        public Vehicle(int price, int maxSpeed, int productionYear)
        {
            this.price = price;
            this.maxSpeed = maxSpeed;
            this.productionYear = productionYear;
        }
        public Vehicle() { }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0) price = value;
            }
        }

        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                if (value > 0) maxSpeed = value;
            }
        }
        public int YearOfCreation
        {
            get
            {
                return productionYear;
            }
            set
            {
                if (value <= DateTime.Today.Year) productionYear = value;
            }
        }
    }
}
