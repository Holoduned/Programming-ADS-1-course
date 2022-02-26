using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Programming.Домашние__2_семестр.Homework_21_02_2022
{
    class Programm
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int[] numbers = Array.ConvertAll(FileManager.ReadFile(path).Split(" "), int.Parse);

            CustomList list = new CustomList();
            for (int i = 0; i < numbers.Length; i++)
            {
                list.Add(numbers[i]);
            }

            list.PrintList();

            Console.WriteLine($"Максимальный элемент из списка: {CustomList.MaxElement(list)}");
            Console.WriteLine($"Сумма элементов из списка: {CustomList.SumElement(list)}");
            Console.WriteLine($"Наличие в списке отрицательных элементов: {CustomList.NegativeElement(list)}");

            list.AddBeforeAndAfter(4, 2);
            list.PrintList();

            Console.Write("Удаление определенного элемента/элементов: ");
            CustomList.RemoveAllElements(list, 3, true);
            list.PrintList();

            Console.Write("Удаление первого, последнего и предпоследнего элемента: ");
            list.RemoveHead();
            list.RemoveLast();
            list.RemovePreLast();

            list.PrintList();

        }
    }

}
