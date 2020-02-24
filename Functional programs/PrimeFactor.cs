using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class PrimeFactor
    {
        public static void FactorsOfNumber()
        {
            Console.WriteLine("Enter the number and find the factors:");
            int n = Convert.ToInt32(Console.ReadLine());
            int t = n;
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(t); i += 2)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }
        }
    }
}
