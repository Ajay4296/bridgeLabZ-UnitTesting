using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class Quadratic
    {
        public static void FindRoot()
        {
            Console.WriteLine("enter a first input");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a second input");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a third input");
            int c= Convert.ToInt32(Console.ReadLine());
            double d = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
            if(d<0)
                Console.WriteLine("root is emaginary");
            double root1 = (float)(-b + d) / 2 * a;
            double root2 = (float)(-b - d) / 2 * a;
            Console.WriteLine("first root is" +root1);
            Console.WriteLine("second root is" + root2);
        }





    }
}
