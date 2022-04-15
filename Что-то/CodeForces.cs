/*using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace program
{
    public class Programm
    {
        static void Main(string[] args)
        {
        
            var stringReadLine = Console.ReadLine().Split(' ');
            var s = Console.ReadLine().Split(' ');
        
            var coordinates = Array.ConvertAll(s, int.Parse);
            Array.Sort(coordinates);

            double Max = int.MinValue;
            for (int i = 0; i < int.Parse(stringReadLine[0]) - 1; i++)
            {
                double distance = coordinates[i + 1] - coordinates[i];
                if (distance / 2 > Max)
                {
                    Max = distance / 2;
                }
            }

            Max = Math.Max(Max, coordinates[0]);
            Max = Math.Max(Max, (int.Parse(stringReadLine[1]) - coordinates[coordinates.Length - 1]));
        
            Console.WriteLine(Max);
        }
    }
}*/