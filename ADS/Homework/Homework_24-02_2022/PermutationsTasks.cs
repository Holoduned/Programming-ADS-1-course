using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Homework.Homework_24_02_2022
{
    public class Permutations
    {
        public static string[] GetAllPermutations(int[] input)
        {
            var result = new string[0];
            GetAllPermutations(input, ref result);
            return result;
        }

        public static void GetAllPermutations(int[] input, ref string[] result, string current = "")
        {
            if (input.Length == 0)
            {
                result = result.Append(current).ToArray();
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                var newInput = new int[input.Length];
                input.CopyTo(newInput, 0);
                newInput = newInput.Remove(i);
                GetAllPermutations(newInput, ref result, current + input[i]);
            }
        }
    }

    public class PermutationsTasks
    {
        public static void Subsets(int[] array)
        {
            Array.Sort(array);
            string[] subsets = new string[0];

            for (int i = 0; i < (1 << array.Length); i++)
            {
                string s = "";
                for (int j = 0; j < array.Length; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        s += array[j];
                    }
                }
                subsets = subsets.Append(s).ToArray();
            }

            Couple[] dictionarySubsets = Dictionary.Add(Array.ConvertAll(subsets[1..], int.Parse));
            foreach (Couple i in dictionarySubsets)
            {
                Console.WriteLine(i.Key);
            }
        }

        public static void PossibleSum(int A, int B, int result)
        {
            string[] resultA = new string[0]; string[] resultB = new string[0];
            int[] a = A.ToString().ToCharArray().Select(x => Convert.ToInt32(x.ToString())).ToArray();
            int[] b = B.ToString().ToCharArray().Select(x => Convert.ToInt32(x.ToString())).ToArray();

            Permutations.GetAllPermutations(a, ref resultA);
            Permutations.GetAllPermutations(b, ref resultB);

            bool possible = false;
            foreach (string i in resultA)
            {
                foreach (string j in resultB)
                {
                    if (Convert.ToInt32(i) + Convert.ToInt32(j) == result)
                    {
                        possible = true;
                        Console.WriteLine("YES");
                        Console.WriteLine(Convert.ToInt32(i) + " " + Convert.ToInt32(j));
                        return;
                    }
                }
            }
            if (!possible) { Console.WriteLine("NO"); }
        }
    }
}