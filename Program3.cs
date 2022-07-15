using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba3
{
    internal class Program
    {
       static int NotContains(int[] array)
        {
            for (int i = 1; i < array.Length + 1; i++)
            {
                if (!array.Contains(i))
                {
                    return i;
                }
            }
            return array.Length + 1;
        }
        static void Main(string[] args)
        {
            int[] masiv = {1,2,3,4,5,6};
            int[] masiv1 = { 1, 2, 3, 4, 6 };
            Console.WriteLine(NotContains(masiv));
            Console.WriteLine(NotContains(masiv1));
            Console.ReadLine();
        }
    }
}
