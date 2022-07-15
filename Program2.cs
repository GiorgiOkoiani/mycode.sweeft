using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba2
{
    internal class Program
    {
         static int MinSplit(int amount)
        {
            int a, b, c, d,e ,money,coins;
            money = amount;
            a = money / 50;
            b = (money % 50) / 20;
            c = ((money % 50) % 20) / 10;
            d = (((money % 50) % 20)%10)/5;
            e = (((money % 50) % 20)%10)%5;
            coins=a+b+c+d+e;
            return coins;

        }
        static void Main(string[] args)
        {
            int money,amount;
            Console.WriteLine("Enter money");

            money=int.Parse(Console.ReadLine());
            amount = MinSplit(money);
            Console.WriteLine("Minimal number of coins  "+amount);
            Console.ReadLine();
        }
    }
}
