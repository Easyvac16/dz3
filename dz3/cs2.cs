using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    internal class cs2
    {
        public static bool IsPalindrome(int number)
        {
            int reverse = 0;
            int original = number;

            while (original > 0)
            {
                int digit = original % 10;
                reverse = reverse * 10 + digit;
                original /= 10;
            }

            return reverse == number;
        }




    }
}
