using System;

namespace Functional_programs
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("0.get percentage of head and tail");
            Console.WriteLine("1.Replace string of username.");
            Console.WriteLine("2. Find leap year or not.");
            Console.WriteLine("3. Get power of two table.");
            Console.WriteLine("4. Find the Nth harmonic Value.");
            Console.WriteLine("5. Find the Prime factors.");
            Console.WriteLine("6. Print the 2D array.");
            Console.WriteLine("7. Find the triplats in the array elements.");
            Console.WriteLine("8. Find the distance between origin and given point.");
            Console.WriteLine("9. Find the Roots.");
            Console.WriteLine("10. Find the WindChill.");
            Console.WriteLine("Enter the choice:- ");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 0:
                    {
                        FlipFlopCoin.Percentage();
                        break;
                    }
                case 1:
                    {
                        ReplaceString.Replaces();
                        break;
                    }
                case 2:
                    {
                        LeapYear.FindLeapYear();
                        break;
                    }
                case 3:
                    {
                        PowerOfTwo.FindPowerOfTwo();
                        break;
                    }
               case 4:
                    {
                        Harmonic.FindNthHarmonicNumber();
                        break;
                    }
                case 5:
                    {
                        PrimeFactor.FactorsOfNumber();
                        break;
                    }
               case 6:
                    {
                        TwoDarray.ArrayInt();
                        break;
                    }
               case 7:
                    {
                        SumofThree.FindTriplats();
                        break;
                    }
                case 8:
                    {
                        Distance.FindDistance();
                        break;
                    }
                case 9:
                    {
                        Quadratic.FindRoot();
                        break;
                    }
                case 10:
                    {
                        WindChil.Chill();
                        break;
                    }
                default:
                    Console.WriteLine("No match found");
                    break;
            }
        }

    }
}

