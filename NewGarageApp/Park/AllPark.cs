using System;

namespace NewGarageApp.Park
{
    class AllPark
    {
        public static readonly int generalSpace = 20;
        public static int busySpaceCount;

        ParkSpace[,] space;
        static int[,] parkMap = new int[4, 5];

        public AllPark()
        {
            space = new ParkSpace[4, 5];
        }

        static bool Free(int r, int c)
        {
            if (parkMap[r, c] == 1)
            {
                return false;
            }
            else
            {
                parkMap[r, c] = 1;
                return true;
            }
        }

        public ParkSpace this[int row, int column]
        {
            get
            {
                return space[row, column];
            }
            set
            {
                if (Free(row, column))
                {
                    space[row, column] = value;
                }
                else
                {
                    busySpaceCount--;
                    throw new Exception("This space arleady is busy");
                }
            }
        }

        public static void ParkTable()
        {
            for (int i = 0; i < parkMap.GetLength(0); i++)
            {
                for (int j = 0; j < parkMap.GetLength(1); j++)
                {
                    if (parkMap[i, j] == 0)
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

        public override string ToString()
        {
            return $"Park total space is {generalSpace} (3 row,4 column)\n" +
                   $"Now busy space count is {busySpaceCount}\n\n" +
                   $"Where would you like to book?";
        }
    }
}
