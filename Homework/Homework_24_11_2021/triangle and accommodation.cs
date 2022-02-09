using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Homework_24_11_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var hotel = new Hotel();
            hotel = hotel.CreateHotel();
            hotel.Populate();
            hotel.PrintHotel();

            Console.WriteLine();

            var rental = new Rental();
            rental = rental.CreateRental();
            rental.PrintRental();
            rental.Populate();


            var isos_triangle = new IsoscelesTriangle(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            isos_triangle.PrintTriangle();
            Console.WriteLine($"Площадь равнобедренного треугольника: {isos_triangle.square_isosceles}");

            var rect_triangle = new RectangularTriangle(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            rect_triangle.PrintTriangle();
            Console.WriteLine($"Площадь прямоугольного треугольника: {rect_triangle.square_rectangular}");

            Console.ReadKey();
        
        }
    }
}
