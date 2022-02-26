using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_programming
{
   public class PerfectNo
    {
        public static void FindPerfeftNo()
        {
            int num, sum, mn, mx;
            Console.WriteLine("Finding perfect no. in given serise");
            Console.WriteLine("Enter a no");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter ending no");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Perfect number are :");

            for (num = mn; num <= mx; num++)
            {
                int i = 1;
                sum = 0;
                while (i < num)
                {
                    if (num % i == 0) 
                    sum += i;
                    i++;

                }
                if (sum == num)
                    Console.WriteLine(sum);


            }
            
        }
    }
}
