using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba1
{
    internal class Program
    {
        static bool IsPalindrome(string text)
        {
            return text == new string(text.Reverse().ToArray());

            if (IsPalindrome(text))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
static void Main(string[] args)
        {
           Console.Write("Enter the string ");
            string text = Console.ReadLine();
            Console.WriteLine(IsPalindrome(text));
            Console.ReadLine();




        }
    }
}

