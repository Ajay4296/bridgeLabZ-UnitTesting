using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class PowerOfTwo

    {
        public static void FindPowerOfTwo()
        {
            Console.WriteLine(" enter power ");
            int p = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<=p;i++)
            {
                double n = Math.Pow(2, i);
                Console.WriteLine(2+"^"+i+"="+n);
            }

        }

    }
}
