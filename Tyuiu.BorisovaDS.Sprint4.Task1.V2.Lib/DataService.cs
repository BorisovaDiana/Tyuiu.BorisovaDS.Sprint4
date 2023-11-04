using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BorisovaDS.Sprint4.Task1.V2.Lib
{
    public class DataService : ISprint4Task1V2
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            foreach (int x in array)
            {
                if (x >= 1 && x <= 7 && x % 2 != 0)
                {
                    sum += x;
                }
            }

            return sum;
        }
    }
}
