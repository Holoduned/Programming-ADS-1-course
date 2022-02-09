////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace Study.Homework.Homework_27_10_2021
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            #region Задача 1
////            Console.Write("Введите количество студентов, информацию о которых необходимо внести: ");
////            int number = Convert.ToInt32(Console.ReadLine());
////            Student[] students = Student.InputInfo(number);
 
////            for (int i = 0; i < students.Length; i++)
////            {
////                students[i].GetInfo();
////                Console.ReadKey();
////            }
////            #endregion

////            #region Задача 2
////            Console.Write("Введите количество окружностей, над которыми необходимо провести операции: ");
////            int radius = Convert.ToInt32(Console.ReadLine());
////            Circle[] circles = Circle.InputInfo(radius);

////            for (int i = 0; i < circles.Length; i++)
////            {
////                circles[i].Info();
////                Console.ReadKey();
////            }
////            #endregion

////            #region Задача 3
////            Console.Write("Введите первое число: ");
////            string n = Console.ReadLine();
////            Console.Write("Введите второе число: ");
////            string n_2 = Console.ReadLine();
////            BigNumber num = new BigNumber(n, n_2);

////            num.Inf();
////            Console.ReadKey();
////            #endregion
////        }

////    }
////}
