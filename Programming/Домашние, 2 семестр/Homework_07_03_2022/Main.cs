using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Programming.Домашние__2_семестр.Homework_07_03_2022
{
    class Programm
    {
        static void Main(string[] args)
        {
            CustomList<string> list = new CustomList<string>();
            list.Add("6");
            list.Add("3");
            list.Add("9");
            list.Add("1");
            list.Add("3");
            list.Add("2");
            list.PrintList();

            //list.RemoveHead();
            //list.RemoveLast();
            //list.RemovePreLast();
            //list.RemoveAllElements("3", false);
            //list.AddPosition("5", 3);
            //list.AddBeforeAndAfter("7", "3");
            //list.Swap();

            list = list.Reverse();
            list.PrintList();

            Console.WriteLine(list.MaxElement());
            Console.WriteLine(list.NegativeElement());
            Console.WriteLine(list.SumElement());


        }
    }
}
