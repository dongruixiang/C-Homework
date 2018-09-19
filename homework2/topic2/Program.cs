using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic2
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = -500;
            int min = 500;
            int sum = 0;
            int[] num =new int[5]{ 6, 3, 4, 5, 9 };
            for (int i = 0; i < num.Length; i++)
            {
                
                
                if (max<num[i])
                {
                   max = num[i];
                }
               
            
            }
            Console.WriteLine("The max is " + max);
            for (int i = 0; i < num.Length; i++)
            {
                
                if (min>num[i])
                {
                    min = num[i];
                }
              
            }
            Console.WriteLine("The min is " + min);

            for (int i = 0; i < num.Length; i++)
            {

                sum = num[i] + sum;

            }
            Console.WriteLine("The sum is " + sum);
            double average = Convert.ToDouble(sum) / num.Length;
            Console.WriteLine("The average number is " + average);

        }
    }
}
