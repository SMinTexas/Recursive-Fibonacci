using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        public static int FibonacciSeries(int n)
        {
            if (n == 0) return 0; //to return the first Fibonacci number
            if (n == 1) return 1; //to return the second Fibonacci number
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }

        public static void Main()
        {
            Console.WriteLine("Enter the length of the Fibonacci Series : ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", FibonacciSeries(i));
            }

            Console.Read();
        }
    }
}
