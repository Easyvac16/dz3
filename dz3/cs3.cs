using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    internal class cs3
    {
        public static void FilterArray(int[] originalArray, int[] filterArray)
        {
            List<int> resultList = new List<int>();

            foreach (int num in originalArray)
            {
                if (!filterArray.Contains(num))
                {
                    resultList.Add(num);
                }
            }
            string resultString = string.Join(" ", resultList);
            Console.WriteLine(resultString);


        }

    }
}
