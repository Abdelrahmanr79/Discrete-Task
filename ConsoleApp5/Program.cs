using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How to find the perfect number between the starting number and the ending number in the domain :");
            Console.WriteLine("..................................................................................................");
            int w, h, i, sum = 0;
            Console.Write("enter the starting number of the domain :- ");
            w = int.Parse(Console.ReadLine());
            Console.Write("enter the ending number of the domain ;- ");
            h = int.Parse(Console.ReadLine());
            while (w <= h)
            {
                sum = 0;
                for (i = 1; i <= w / 2; i++)
                {
                    if (w % i == 0)
                    {
                        sum = sum + i;
                    }
                }
                if (sum == w)
                    Console.WriteLine(w);
                w++;


            }
            Console.ReadKey();
        }
    }
}
