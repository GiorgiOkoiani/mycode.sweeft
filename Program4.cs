using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba 4
{
    internal class Program
    {
       static bool IsProperly(string sequence)
        {
            
            
                int a = -1;
                while (sequence.Length != a)
                {
                    a = sequence.Length;
                    sequence = sequence.Replace("()", "");
                    
                }
                if (sequence.Length == 0) return true;
                else return false;
            }

        
        static void Main(string[] args)
        {
            Console.WriteLine(IsProperly("())()"));
            Console.ReadLine();
        }
    }
}
