using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"abba = {IsPalindrome("abba")}");
            Console.WriteLine($"leri = {IsPalindrome("leri")}");
            Console.WriteLine($"airevisiveria = {IsPalindrome("airevisiveria")}");
            Console.ReadLine();
        }

        static bool IsPalindrome(string text)
        {
            if (text.Length < 2)
                return false;
            int left = 0;
            int right = text.Length - 1;
            while (left < right)
            {
                if (text[left] != text[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
