using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string s;
            Console.Write("Input a positive integer:");
            s = Console.ReadLine();
            i = int.Parse(s);
            Console.WriteLine("All his prime factors are");
            for (int j = 2; j <= i; j++)
            {
                if (i % j == 0)
                {
                    Console.WriteLine(j);
                    i = i / j;

                }
            }

        }
    }
}
