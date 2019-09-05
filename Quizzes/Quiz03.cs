/*****************************
 * Name:Quiz03****************
 * Author: Cherif Ouedraogo***
 * Date: July 18, 2019*******/


using System;

namespace Quiz03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine("To calculate the reciprocal of an integer, enter a positive integer:");
                try
                {
                    int denom = Convert.ToInt32(Console.ReadLine());
                    if (denom == 0)
                        throw new DivideByZeroException("Attempted to Divide By Zero");
                    else if (denom < 0)
                        throw new Exception(" Your number must be a positive number");
                    else
                    {
                        double recip = 1.0 / denom;
                        Console.WriteLine($" The reciprocal is {recip}");
                        run = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input string was not in a correct format");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Attempted to Divide By Zero");
                }
                catch (Exception)
                {
                    Console.WriteLine("Your number must be a positive number");
                }
            }
      
        }
    }

}
