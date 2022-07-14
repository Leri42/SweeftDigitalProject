using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveStairs
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int CountVariants(int stairCount)
        {
            if (stairCount < 3)
                return stairCount;
            int first = 1;
            int second = 2;

            for (int i = 2; i < stairCount; i++)
            {
                int temp = first + second;
                first = second;
                second = temp;
            }
            return second;
        }
    }
}
