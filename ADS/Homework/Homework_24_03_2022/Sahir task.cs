using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Homework.Homework_24_03_2022
{
    public class SahirTask
    {
        public static int SahirRun(int[,] building)
        {
            int time = GetRow(building, building.GetLength(0) - 1)
                .Contains(1) ? GetRow(building, 0).Count : 1;
            int position = 1;
            for (int i = building.GetLength(0) - 2; i >= 0; i--)
            {
                var floor = GetRow(building, i);

                if (!floor.Contains(1) && i != 0)
                {
                    time += 1;
                }

                else if (i == 0)
                {
                    if (!floor.Contains(1))
                    {
                        return time;
                    }
                    else
                    {
                        CalcDistance();
                    }
                }
                else
                {
                    CalcDistance();

                    int localTimeLeft = floor.IndexOf(1) + GetRow(building, i - 1).IndexOf(1) + 1;
                    int localTimeRight = floor.Count - floor.IndexOf(1) + GetRow(building, i - 1).Count - GetRow(building, i - 1).LastIndexOf(1) - 1;

                    if (localTimeLeft > localTimeRight)
                    {
                        position = 1; time += floor.Count - floor.IndexOf(1);
                    }
                    else { position = 0; time += floor.IndexOf(1) + 1; }

                }

                void CalcDistance()
                {
                    if (position == 1)
                    {
                        time += floor.Count - floor.IndexOf(1) - 1;
                    }
                    else
                    {
                        time += floor.LastIndexOf(1);
                    }
                }
            }

            return time;


            List<int> GetRow(int[,] matrix, int rowIndex)
            {
                var array = new List<int>();
                for (int i = 0; i < matrix.GetLength(1); i++)
                    array.Add(matrix[rowIndex, i]);
                return array;
            }
        }
    }
}