using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZE020
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Enter a positive number");
        Start:
            try
            {

                int denom = Convert.ToInt32(Console.ReadLine());
                if (denom == 0)
                    throw new DivideByZeroException( "Attempted to Divide By Zero");
                else if (denom < 0)
                    throw new Exception (" Your number must be a positive number");
                 else
                {
                    double recip = 1.0 / denom;
                    Console.WriteLine($" The reciprocal is {recip}");
                }
            }
                catch (FormatException)
            {
                Console.WriteLine(" Input string was not in a correct format");
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Attempted to Divide By Zero");
            }
            catch (Exception)
            {
                Console.WriteLine(" Your number must be a positive number");
            }

            goto Start;
           }
        }

    }
