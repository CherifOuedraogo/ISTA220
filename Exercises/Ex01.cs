/************************************************
 * Name: C# Exercise 01**************************
 * Author: Cherif Ouedraogo**********************
 * Date: July, 5 2019***************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part One : circumference and area of a circle . ");


            Console.Write("Enter an integer for the radius : ");
             string strradius = Console.ReadLine();
             int intradius = int.Parse(strradius);
            double circumference = 2*Math.PI*intradius;
             Console.WriteLine($"The circumference of the circle is {circumference }"); /* Displays the circumference of a circle*/
            double area = Math.PI * intradius * intradius;
            Console.WriteLine($"The area of the circle is {area}");                    /* Displays the area of a circle */

            Console.WriteLine("Part Two : volume of an hemisphere . ");


            Console.Write("Enter a number for the radius : ");
            string hemiradius = Console.ReadLine();
            int radius = int.Parse(hemiradius);
            double volume = (4*Math.PI * radius *radius * radius)/6;  
            Console.WriteLine($"The volume of the hemisphere is {volume}");  /*Displays the volume of an hemisphere */


            Console.WriteLine("Part Three : area of a triangle (Heron's formula ) . ");


            Console.Write("Enter an integer for the first side : ");
            string strsidea = Console.ReadLine();
            int intsidea = int.Parse(strsidea);
            Console.Write("Enter an integer for the second side : ");
            string strsideb = Console.ReadLine();
            int intsideb = int.Parse(strsideb);
            Console.Write("Enter an integer for the third side : ");
            string strsidec = Console.ReadLine();
            int intsidec = int.Parse(strsidec);
            double p =(intsidea + intsideb + intsidec)/2;
            double surface =(Math.Sqrt(p*(p-intsidea)*(p-intsideb)*(p-intsidec)));
            Console.WriteLine($"The area of the triangle is {surface}");                   /*Displays the area a triangle */

            Console.WriteLine( "Part Four: solving a quadratic equation . ");
            

             Console.Write("Enter an integer for the first coefficient : ");
            string strcoefa = Console.ReadLine();
            int intcoefa = int.Parse(strcoefa);
            Console.Write("Enter an integer for the second coefficient : ");
            string strcoefb = Console.ReadLine();
            int intcoefb = int.Parse(strcoefb);
            Console.Write("Enter an integer for the constant : ");
            string strconstant = Console.ReadLine();
            int intconstant = int.Parse(strconstant);
            double x2 =-intcoefb-Math.Sqrt((intcoefb*intcoefb)-(4* intcoefb * intconstant));
            double x1 =-intcoefb + Math.Sqrt((intcoefb * intcoefb)-(4* intcoefb * intconstant));
            Console.WriteLine($"The positive  solution  is { x1}");                              /*Displays the solution for the Quadratic equation */
            Console.WriteLine($"The negative  solution is { x2 }"); 
        }
    }
}
