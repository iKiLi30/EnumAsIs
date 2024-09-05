using System;

namespace EnumAsIs
{
    enum orientation : byte
        {
            north = 1,
            south = 2,
            east = 3,
            west = 4,
     }
    struct route
    {
        public orientation direction;
        public double distance;
    }

    class Program
    {

        static void Main(string[] args)
        {
            route myRoute;
            int myDirection = -1;
            double myDistance = 0;
            Console.WriteLine(" 1. North\n 2.South\n 3.East\n 4.West ");
            do
            {
                Console.WriteLine("Select a direction:");
                myDirection = Convert.ToInt32(Console.ReadLine());
            }
            while ((myDirection < 1) || (myDirection > 4));
            Console.WriteLine("Input a distance: ");
            myDistance = Convert.ToDouble(Console.ReadLine());
            myRoute.direction = (orientation)myDirection;
            myRoute.distance = myDistance;
            Console.WriteLine($"my route {myDirection}" + $"my distance of {myRoute.distance}");
            Console.ReadKey();
        }
    }
}
