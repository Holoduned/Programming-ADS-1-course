using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Homework.Homework_24_02_2022
{
    
    public class Couple
    {
        public int Key; public int Value;
        public Couple(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }

    public class Dictionary
    {
        public static Couple[] Add(int[] array)
        {
            if (array == null)
            {
                throw new Exception("Массив пуст!");
            }

            Couple[] couple = new Couple[0];
            foreach (var element in array)
            {
                int i = 0;
                while (i < couple.Length)
                {
                    if (couple[i].Key == element)
                    {
                        couple[i].Value++;
                        break;
                    }
                    i++;
                }
                if (i == couple.Length)
                {
                    Array.Resize(ref couple, couple.Length + 1);
                    couple[i] = new Couple(element, 1);

                }
            }
            return couple;
        }

        public static void DictionaryPrint(Couple[] arr)
        {
            foreach (var el in arr)
            {
                Console.WriteLine($"Ключ - {el.Key}, значение - {el.Value}");
            }
        }
    }

    public class WorkWithDictionary
    {
        public static void FindElement(Couple[] array, int n)
        {
            foreach (var el in array)
            {
                if (el.Value > Convert.ToDecimal(n) / 2)
                {
                    Console.WriteLine(el.Key + " " +  el.Value);
                }
            }
        }
    }

}
