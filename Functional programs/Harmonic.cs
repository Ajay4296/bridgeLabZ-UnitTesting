using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
     public class Harmonic
    {
        public static void FindNthHarmonicNumber()
        {
            Console.WriteLine(" enter anumber ");
            int n = Convert.ToInt32(Console.ReadLine());
            double hm = 1;
            for(int i=2;i<=n;i++)
            {
                hm = hm +(float) 1 / i;
            }
            Console.WriteLine(n+"th harmonic number is = " +hm);

        }
    }
}
