using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    internal class cs1
    {
        public static void SquareTask_1(int sideLength, char symbol)
        {
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
