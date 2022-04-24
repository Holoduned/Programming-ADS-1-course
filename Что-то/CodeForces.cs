using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Data;

/*namespace program
{
    public class Programm
    {
        static void Main(string[] args)
        {
            var allQueue = new List<string>();
            var students = new List<int>(){1, 2, 3, 4, 5};
            allQueue = GetAllPermutations(students);

            int[,] joy = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                var s = Console.ReadLine().Split(" ");
                for (int j = 0; j < 5; j++)
                {
                    joy[i, j] = int.Parse(s[j]);
                }
            }

            var maxJoy = int.MinValue;
            foreach (var queue in allQueue)
            {
                var q = queue.Select(x => Convert.ToInt32(x.ToString())).ToList();
                var localJoy = 0;
                for (int j = 0; j < queue.Length - 1; j++)
                {
                    for (int i = j; i < queue.Length; i+=2)
                    {
                        if (i != queue.Length - 1)
                        {
                            localJoy += joy[q[i] - 1, q[i + 1] - 1] + joy[q[i + 1] - 1, q[i] - 1];
                        }
                    }
                }
                
                if (localJoy > maxJoy)
                {
                    maxJoy = localJoy;
                }
            }
            
            Console.WriteLine(maxJoy);
        }
        
        private static List<string> GetAllPermutations(List<int> input) 
        {
            var result = new List<string>();
            GetAllPermutations(input, ref result);
            return result;
        }

        private static void GetAllPermutations(List<int> input, ref List<string> result, string current = "") 
        {
            if (input.Count == 0) 
            {
                result.Add(current);
                return;
            }
            for (int i = 0; i < input.Count; i++) 
            {
                var newInput = new List<int>(input);
                newInput.RemoveAt(i);
                GetAllPermutations(newInput, ref result, current + input[i]);
            }
        }
    }
}*/


