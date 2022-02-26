using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_programming
{
    public class Fibonacci
    {
        public static void DisplayFiboacci()
        {
            int n1 = 0, n2 = 1, n3, i, number;

            Console.WriteLine("Enter the no of elements");
            number = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
                

            }
          
        }
    }
}