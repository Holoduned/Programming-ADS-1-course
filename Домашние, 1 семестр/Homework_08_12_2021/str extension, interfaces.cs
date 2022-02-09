using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Study.Homework.Homework_08_12_2021
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите две строки: ");
//            string s1 = Console.ReadLine();
//            string s2 = Console.ReadLine();
//            Console.WriteLine(s1.StringAdd(s2));

//            Console.WriteLine("Вводите значения мнимой и действительной частей дроби");
//            var complexNumber = new ComplexNumber(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
//            Console.Write("Комплексное число: "); complexNumber.ToString();
//            var copy_complexNumber = (ComplexNumber)complexNumber.Clone();
//            Console.Write("Копия комплексного числа: "); copy_complexNumber.ToString();
//            copy_complexNumber.real = 5;
//            Console.Write("Измененная копия комплексного числа и само число: "); copy_complexNumber.ToString();

//            Console.WriteLine("Вводите значения знаменателя и числителя дроби");
//            var fraction = new RationalFraction(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())); fraction.Reduce();
//            Console.Write("Первая дробь равна: "); fraction.ToString();
//            var fraction_2 = new RationalFraction(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())); fraction_2.Reduce();
//            Console.Write("Вторая дробь равна: "); fraction_2.ToString();

//            Console.WriteLine($"Результат сравнения числителей дробей: {fraction.CompareTo(fraction_2)}");
//            Console.WriteLine("Меньше 0 - число меньше. 0 - равны. Больше нуля - число больше");

//            Console.ReadKey();
//        }
//    }
//}
