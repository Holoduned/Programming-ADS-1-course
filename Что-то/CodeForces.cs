/*using System.ComponentModel.DataAnnotations;

namespace Programming.Programming.Домашние__2_семестр.Homework_04_04_2022;

public class Programm
{
    static void Main(string[] args)
    {
        var stringReadLine = Console.ReadLine().Split(" ");
        var s = Console.ReadLine().Split(" ");
        
        var coordinates = Array.ConvertAll(s, int.Parse);
        Array.Sort(coordinates);

        double Max = int.MinValue;
        for (int i = 0; i < int.Parse(stringReadLine[0]) - 1; i++)
        {
            double distance = coordinates[i + 1] - coordinates[i];
            if (distance > Max)
            {
                Max = distance / 2;
            }
        }

        Max = Math.Max(Max, coordinates[0]);
        Max = Math.Max(Max, (int.Parse(stringReadLine[1]) - coordinates[coordinates.Length - 1]));
        
        Console.WriteLine(Max);
    }
}*/