using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_programs
{
    public class TwoDarray
    {
       
		public	static void ArrayInt()
        {
			Console.WriteLine("Enter Row and Column:");
			int m = Convert.ToInt32(Console.ReadLine());
			int n = Convert.ToInt32(Console.ReadLine());
			int[,] a = new int[m, n];
			//Console.WriteLine();
			Console.WriteLine("Enter the Array elements.");

			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < n; j++)
				{
					a[i, j] = Convert.ToInt32(Console.ReadLine());
				}
			}
			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(a[i, j] + " ");
				}
				//Console.WriteLine();
			}
		}
	}

}

