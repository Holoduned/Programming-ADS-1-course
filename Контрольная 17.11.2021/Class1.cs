using System;
using System.Linq ;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.NewFolder2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите количество людей на занятии: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Student[] students = Student.InputInfo(count);

            Console.Write("Введите количество вопросов, которые будут заданы на занятии: ");
            int count_question = Convert.ToInt32(Console.ReadLine());

            Desk desk = new Desk(count_question);
            desk.WorkAtDesk(students);

            Console.ReadKey();

        }
    }
}