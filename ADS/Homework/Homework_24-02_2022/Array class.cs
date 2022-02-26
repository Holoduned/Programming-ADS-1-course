using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Homework.Homework_24_02_2022
{
    public static class ArrayExtenstion
    {         
        public static int[] Remove(this int[] array, int index)
        {
            int[] newArray = new int[0];
            
            for (int j = 0; j < array.Length; j++)
            {
                if (j != index)
                {
                    newArray = newArray.Append(array[j]).ToArray();
                }
            }

            return newArray;
        }
    }
}
