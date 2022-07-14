using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"101 , {MinSplit(101)}");
            Console.WriteLine($"47 , {MinSplit(47)}");
            Console.ReadLine();
        }

        static int MinSplit(int amount)
        {
            int[] coins = new int[] { 1, 5, 10, 20, 50 };
            int count = 0;
            int currentIndex = coins.Length - 1;
            while (amount > 0)
            {
                if (coins[currentIndex] > amount)
                {
                    currentIndex--;
                    continue;
                }
                //amount -= coins[currentIndex];
                //count++;

                int num = amount / coins[currentIndex];
                count += num;
                amount -= num * coins[currentIndex];
                currentIndex--;
            }
            return count;
        }
    }
}
