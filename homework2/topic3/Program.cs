using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic3
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean[] num = new Boolean[101];
            num[0] = false;
            num[1] = false;
            for (int i = 2; i <= 100; i++)
            {
                num[i] = true;
            }
            for (int i = 2; i <= 10; i++)
            {
                if (num[i]== true)
                {
                    for (int j = i; j * i <= 100; j++)
                    {
                        num[j * i] = false;
                    }
                }
            }
            for (int i = 2; i <= 100; i++)
            {
                if (num[i] == true)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
