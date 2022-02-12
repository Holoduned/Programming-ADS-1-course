using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Домашние__2_семестр._10._02
{
    public class WorkWithArray
    {
        public static int[] ArrayMerge(int[][] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int[] num_array1 = array[i]; int[] num_array2 = array[i + 1];
                int[] merge_array = new int[num_array1.Length + num_array2.Length];
                int a = 0; int b = 0;

                for (int j = 0; j < merge_array.Length; j++)
                {
                    if (a < num_array1.Length && b < num_array2.Length && Convert.ToInt32(num_array1[a]) <= Convert.ToInt32(num_array2[b]))
                    {
                        merge_array[j] = num_array1[a];
                        a++;
                    }
                    else if (a < num_array1.Length && b < num_array2.Length && Convert.ToInt32(num_array1[a]) > Convert.ToInt32(num_array2[b]))
                    {
                        merge_array[j] = num_array2[b];
                        b++;
                    }
                    else if (a > num_array1.Length - 1)
                    {
                        merge_array[j] = num_array2[b];
                        b++;
                    }
                    else if (b > num_array2.Length - 1)
                    {
                        merge_array[j] = num_array1[a];
                        a++;
                    }
                }

                array[i + 1] = merge_array;
            }

            return array[array.Length - 1];
        }

        public static int[] DifferenceArray(int[][] array)
        {
            List<int> difflist = new List<int>();

            for (int i = 0; i < array[0].Length; i++)
            {
                if (array[1].Contains(array[0][i]))
                {
                    continue;
                }
                else
                {
                    difflist.Add(array[0][i]);
                }
            }

            return difflist.ToArray();
        }

        public static void ArrayPrint(int[] array)
        {
            Console.WriteLine(String.Join(" ", array));
        }

        public static int[][] ArraysCreate(string[] array)
        {
            int[][] arrays = new int[array.Length][];

            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    arrays[i] = Array.ConvertAll(array[i].Split(" "), int.Parse);
                    int[] arr = Array.ConvertAll(array[i].Split(" "), int.Parse);
                    Array.Sort(arr);
                    if (!arrays[i].SequenceEqual(arr))
                    {
                        Console.WriteLine("Один из введенных массивов не является отсортированным");
                        throw new Exception("Введенный массив не является отсортированным");
                    }
                }
                catch 
                {
                    Array.Sort(arrays[i]);
                    Console.WriteLine("Массив был отсортирован");
                }
            }

            return arrays;
        }
    }

    public class FileManager
    {
        public static string[] ReadFile(string path)
        {

            while (!File.Exists(path) || !Directory.Exists(Path.GetDirectoryName(path)) || path == null)
            {
                Console.WriteLine("Директории или файла не существует или не был введен путь к файлу.");
                path = Console.ReadLine();
            }

            return File.ReadAllLines(path);
        }
    }
}
