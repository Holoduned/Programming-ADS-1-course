using System;
using ADS.Homework.Karatsuba;

namespace ADS.Homework.Homework_31_03_2022;

public class Program
{
    static void Main(string[] args)
    {
        var x = Convert.ToInt32(Console.ReadLine());
        var y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(KaratsubaFastMult.Karatsuba(x, y));
    }
}     