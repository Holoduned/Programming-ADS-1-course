using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Homework.Homework_24_02_2022
{
    class Programm
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 4, 1, 1 };
            Couple[] dictionary = Dictionary.Add(mas);
            WorkWithDictionary.FindElement(dictionary, mas.Length);

            PermutationsTasks.PossibleSum(101, 2, 13);
            PermutationsTasks.Subsets(mas);

            
        }
    }
}
