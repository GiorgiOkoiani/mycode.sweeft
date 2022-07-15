using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba 5
{
    internal class Program
    {
      
        
            static int CountVariants(int stairCount)
            {
            if( stairCount == 1)
            {
                return 1;
            }
            else {
                return CountVariants(stairCount - 1) + CountVariants(stairCount - 2);
            }
            }

            static void Main()
        {
            int n = int.Parse(Console.ReadLine());
                Console.WriteLine(CountVariants(n));
                Console.ReadLine();
            
        }
    }
}


