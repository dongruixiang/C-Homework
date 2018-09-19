using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int n = 0;
            int m = 0;
            int c = 0;
            Console.Write("Please input the first int:");
            s = Console.ReadLine();
            n = Int32.Parse(s);
            Console.Write("Please input the second int:");
            s = Console.ReadLine();
            m = Int32.Parse(s);
            c = m * n;
            Console.WriteLine("You have entered:" + n +"and" + m );
            Console.Write("The product is " + c);
        }
    }
}
