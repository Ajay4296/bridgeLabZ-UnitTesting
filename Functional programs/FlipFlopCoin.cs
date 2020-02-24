using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class FlipFlopCoin
    {
        public static void Percentage()
        {
            int head = 0,tail=0;

            Console.WriteLine("enter the number of time you want to flipflop  ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            while (n >= 1)
            { 
                int num = random.Next(2);
                if (num == 1)
                    head++;
                else
                    tail++;
                n--;
            }
            Console.WriteLine("head="+head);
            Console.WriteLine(" tail="+tail);
            Console.WriteLine("percentage of head ="+head*100/n);
            Console.WriteLine("Percentage of tail="+tail/n*100+"%");

        }
    }
}
