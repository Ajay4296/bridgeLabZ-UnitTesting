using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class LeapYear
    {
        public static void FindLeapYear()
        {
            Console.WriteLine("Enter a four digit year");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y % 4 == 0 && y % 100 != 0|| y % 400 == 0)
            Console.WriteLine("it is a Leapyear");
            else
                Console.WriteLine("not a leap year");
        }
    }
}
