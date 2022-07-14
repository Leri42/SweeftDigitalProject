using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdMinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NotContains(new int[] { 100, 1, 4, 5, 3 }));
            Console.ReadLine();
        }

        static int NotContains(int[] array)
        {
            HashSet<int> nums = new HashSet<int>();
            foreach (var n in array)
                nums.Add(n);
            int min = 1;
            while (min < int.MaxValue)
            {
                if (nums.Contains(min))
                    min++;
                else
                    return min;
            }
            return int.MaxValue;
        }
    }
}
