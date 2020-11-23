using System;
using System.Collections.Generic;

namespace ParkingApp.Backend
{
    abstract class Parking
    {
        protected List<Car> Cars { get; set; }
        protected int[,] ParkMap { get; set; }
        public int Space { get; protected set; }
        protected int BusySpace { get; set; }
        public int FreeSpace { get; protected set; }
        public Camera Camera { get; set; }
        public Terminal Terminal { get; set; }

        private bool CheckPlace(int r, int c)
        {
            return ParkMap[r, c] == 1 ? true : false;
        }

        public Parking()
        {
            Camera = new Camera();
            Terminal = new Terminal();
        }

        public void ParkTable()
        {
            for (int i = 0; i < ParkMap.GetLength(0); i++)
            {
                for (int j = 0; j < ParkMap.GetLength(1); j++)
                {
                    if (ParkMap[i, j] == 0)
                    {
                        Console.Write("|____|");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write($"|    |");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
        }

        public Check Enter(Car car, int row, int column)
        {
            Check check = new Check();

            if (!CheckPlace(row, column))
            {
                ParkMap[row - 1, column - 1] = 1;
                check = Camera.CaptureCar(car);
                return Terminal.GiveCheck(check, row, column);
            }

            check.info = "The place is busy\nPlease choose another place";
            return check;
        }

        public void Leave(Car car)
        {
            

        }
    }
}
