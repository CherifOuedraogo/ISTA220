/**********************************************
 * Name: Quiz09
 * Author: Cherif Ouedraogo
 * Date: August 27, 2019**********************/

using System;
using System.Collections.Generic;

namespace Quiz09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is test 09 ");
            Console.WriteLine();
            Stack<string> numbers = new Stack<string>();
            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            Console.WriteLine("Here is the Stack ");
            foreach (string number in new string[3] {"One","Two","Three"})
                Console.WriteLine(numbers.Pop());
            Console.WriteLine();

            Queue<string> values = new Queue<string>();
            values.Enqueue("one");
            values.Enqueue("two");
            values.Enqueue("three");
            Console.WriteLine("Here is the Queue ");
            foreach (string value in values)
                Console.WriteLine(value);
            Console.WriteLine();

            Dictionary<string, int> myNumbers = new Dictionary<string, int>
            {
                { "One", 1 },
                { "Two", 2 },
                { "Three", 3 }
            };
            Console.WriteLine("Here is the Dictionary ");
            foreach (KeyValuePair<string, int> kvp in myNumbers)
                Console.WriteLine($"{ kvp.Key} {kvp.Value}");
        }
    }
}
