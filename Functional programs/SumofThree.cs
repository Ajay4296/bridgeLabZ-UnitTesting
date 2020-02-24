using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    class SumofThree
    {
        public static void FindTriplats()
        {
            Console.WriteLine(" enter the size of array ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine(" enter the number in array ");
            for (int i = 0; i < n; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());
            for (int i= 0;i<n-2;i++)
            {
                for(int j=i+1;j<n-1;j++)
                {
                    for(int k=0;k<n;k++)
                    {
                        int sum = array[i] + array[j] + array[k];
                        if(sum==0)
                            Console.WriteLine(" "+array[i]+" , "+array[j]+" , "+array[k] );
                    }
                }
            }

        }
    }
}
