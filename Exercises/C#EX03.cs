/************************************************
 * Name: C# Exercise 03**************************
 * Author: Cherif Ouedraogo**********************
 * Date: July, 20 2019***************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEx03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
          {
                Console.WriteLine("Part One : Circumference and Area of a Circle  ");
                Console.Write("Enter an integer for the radius : ");
                try
                {
                    string strradius = Console.ReadLine();
                    int intradius = int.Parse(strradius);
                    if (intradius == 0)
                        throw new InvalidOperationException("Attemped to multiply by zero");
                    else if (intradius < 0)
                        throw new Exception("Your number is Out of Range");
                    else
                    {
                        double circumference = 2 * Math.PI * intradius;
                        Console.WriteLine("Okay");
                        Console.WriteLine($"The circumference of the circle is {circumference }");
                        double area = Math.PI * intradius * intradius;
                        Console.WriteLine($"The area of the circle is {area}");                        
                       
                    }

                }  
                catch (FormatException)
                {
                    Console.WriteLine(" Bad Input! You Must Enter a Valid Number.");
                }

                catch (InvalidOperationException)
                {
                    Console.WriteLine("Attempted to multiply by zero");
                }
                catch (Exception)
                {
                    Console.WriteLine("Your number is Out of Range");
                }
                
                finally
                {
                    Console.WriteLine("Okay");
                }
                 Console.WriteLine("Part Two : Volume of an Hemisphere . ");
                        Console.Write("Enter a number for the radius : ");
                try
                {
                    string hemiradius = "";
                    hemiradius = Console.ReadLine();
                    int inthemiradius = int.Parse(hemiradius);
                    if (inthemiradius == 0)
                        throw new InvalidOperationException("Attemped to multiply by zero");
                    else if (inthemiradius < 0)
                        throw new Exception("Your number is out of range");
                    else
                    {
                        double volume = (4 * Math.PI * inthemiradius * inthemiradius * inthemiradius) / 6;
                        Console.WriteLine($"The volume of the hemisphere is {volume}");                       
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Bad Input! You Must Enter a Valid Number.");
                }

                catch (InvalidOperationException)
                {
                    Console.WriteLine("Attempted to multiply by zero");
                }
                catch (Exception)
                {
                    Console.WriteLine("Your number is Out of Range");
                }
                
                finally
                {
                    Console.WriteLine("Okay");
                }
                        Console.WriteLine("Part Three : area of a triangle (Heron's formula )  ");
                        Console.Write("Enter an integer for the first side : ");
                        Console.Write("Enter an integer for the second side : ");
                        Console.Write("Enter an integer for the third side : ");
                try
                {
                    string strsidea = Console.ReadLine();
                    int intsidea = int.Parse(strsidea);
                    string strsideb = Console.ReadLine();
                    int intsideb = int.Parse(strsideb);
                    string strsidec = Console.ReadLine();
                    int intsidec = int.Parse(strsidec);
                    if (intsidea == 0)
                        throw new InvalidOperationException("Attemped to multiply by zero");
                    else if (intsidea < 0)
                        throw new Exception("Your number must be a postive number");
                    else if (intsideb == 0)
                        throw new InvalidOperationException("Attemped to multiply by zero");
                    else if (intsideb < 0)
                        throw new Exception("Your number must be a postive number");
                    else if (intsidec == 0)
                        throw new InvalidOperationException("Attemped to multiply by zero");
                    else if (intsidec < 0)
                        throw new Exception("Your number must be a postive number");
                       else
                    {
                        double p = (intsidea + intsideb + intsidec) / 2;
                        double surface = (Math.Sqrt(p * (p - intsidea) * (p - intsideb) * (p - intsidec)));
                        Console.WriteLine($" The area of the triangle is {surface}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Bad Input! You Must Enter a Valid Number.");
                }

                catch (InvalidOperationException)
                {
                    Console.WriteLine("Attempted to multiply by zero");
                }
                finally
                {
                    Console.WriteLine("Okay");
                }
                Console.WriteLine("Part Four: Solving a Quadratic Equation  ");
                Console.Write("Enter an integer for the first coefficient : ");
                Console.Write("Enter an integer for the second coefficient : ");
                Console.Write("Enter an integer for the constant : ");
                try
                        {
                            string strcoefa = Console.ReadLine();
                            int intcoefa = int.Parse(strcoefa);
                            string strcoefb = Console.ReadLine();
                            int intcoefb = int.Parse(strcoefb);
                            string strconstant = Console.ReadLine();
                            int intconstant = int.Parse(strconstant);
                            if (intcoefa == 0)
                                throw new DivideByZeroException("Divided by zero");
                            else if (((intcoefb * intcoefb) - (4 * intcoefb * intconstant)) < 0)
                                throw new InvalidOperationException("Value must be positive under square root ");
                            else
                            {
                                double x1 = -intcoefb + Math.Sqrt((intcoefb * intcoefb) - (4 * intcoefb * intconstant));
                                double x2 = -intcoefb - Math.Sqrt((intcoefb * intcoefb) - (4 * intcoefb * intconstant));
                                Console.WriteLine($"The positive  solution  is { x1}");                                    
                                Console.WriteLine($"The negative  solution is { x2 }");
                                run = false;
                            }


                        }
                        catch (FormatException)
                        {
                            Console.WriteLine(" Bad Input! You Must Enter a Valid Number.");
                        }

                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Attempted to multiply by zero");
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Attempted to divide by zero");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Your number is Out of Range");
                        }
                        

                             finally
                        {
                            Console.WriteLine("Okay");
                        }











                    }
                    
                }

            }           
              
        }
            
    

