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
                if (!array[1].Contains(array[0][i]))
                {
                    difflist.Add(array[0][i]); ;
                }
            }

            return difflist.ToArray();
        }

        public static int[] IntersectionArray(int[][] array)
        {
            List<int> Interlist = new List<int>();

            for (int i = 0; i < array[0].Length; i++)
            {
                if (array[1].Contains(array[0][i]))
                {
                    Interlist.Add(array[0][i]); ;
                }

            }

            return Interlist.ToArray();
        }

        public static string MaxNumberArray(int[][] array)
        {
            string[] maxNumber = Array.ConvertAll(array[0], x => x.ToString());
            Array.Sort(maxNumber); Array.Reverse(maxNumber);

            for (int j = 0; j < maxNumber.Length; j++)
            {
                for (int i = 0; i < maxNumber.Length - 1; i++)
                {
                    if (Convert.ToInt32(maxNumber[i] + maxNumber[i + 1]) < Convert.ToInt32(maxNumber[i + 1] + maxNumber[i]))
                    {
                        string temp = maxNumber[i];
                        maxNumber[i] = maxNumber[i + 1];
                        maxNumber[i + 1] = temp;
                    }
                }
            }

            return String.Join("", Array.ConvertAll(maxNumber, int.Parse));
        }
        public static void ArrayPrint(int[] array)
        {
            Console.WriteLine(String.Join(" ", array));
        }

        public static int[][] ArraysCreate(string[] array)
        {
            int[][] arrays = { };

            for (int i = 0; i < array.Length; i++)
            {
                var arr = Array.ConvertAll(array[i].Split(" "), int.Parse);
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        Console.WriteLine("Один из введенных массивов не является отсортированным");
                        throw new Exception("Введенный массив не является отсортированным");
                    }
                }
                arrays = arrays.Append(arr).ToArray();
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
