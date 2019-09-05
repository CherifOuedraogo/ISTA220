

using System;


namespace CSharpQuiz05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is test 05 ");
            Console.WriteLine("The Test String is [I Live therefore I am grateful]");
            string[] saying = new string[] { "I", "Live", "therefore", "I", "am ", "grateful " };
            int Len = saying.Length;
            Console.WriteLine($"The Length of string array is {Len}");
            for (int i = saying.Length - 1; i >= 0; i--)
                Console.WriteLine($"{i} {saying[i]}");
          }
    }
    
}
