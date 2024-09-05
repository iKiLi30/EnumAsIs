using System;

namespace EnumAsIs
{
    enum orientation : byte
        {
            north = 1,
            south = 2,
            east = 3,
            west = 4,
            northwest = 5,
            northeast = 6,
            northwestwest = 7
        }
    class Program
    {
        
        static void Main(string[] args)
        {
            byte directionByte;
            string? directionString;
            orientation myDirection = orientation.north;
            Console.WriteLine($"myDirection = {myDirection}");
            directionByte = (byte)myDirection;
            directionString = Convert.ToString(myDirection);
            Console.WriteLine($"byte equivalent = {directionByte}");
            Console.WriteLine($"string equivalent = {directionString}");
            Console.ReadKey();
        }
    }
}
