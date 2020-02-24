using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class Distance
    {
        public static void FindDistance()
        {
            Console.WriteLine("enter distance from x_axix");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter distance from y_axix");
            int y = Convert.ToInt32(Console.ReadLine());
            double result = (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
            Console.WriteLine("euclined distance is" +result);


        }
        
    }   
}
    