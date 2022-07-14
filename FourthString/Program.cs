using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"((())) = {IsProperly("((()))")}");
            Console.ReadLine();

        }

        public static bool IsProperly(string sequence)
        {
            var bracket = new Stack<char>();
            foreach (char c in sequence)
            {
                if(c== '(')
                    bracket.Push(c);
                else
                {
                    if (!bracket.Any() || bracket.Pop() != '(')
                        return false;
                }
            }
            return !bracket.Any();
        }
    }
}
