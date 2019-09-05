/****************************
 * Name: CsharpEx02*********
 * Author: Cherif Ouedraogo
 * Date: July 15, 2019*****/


using System;

namespace csharpEx02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1 , 2 and 3 : sum , average and grade assignment of 10 number of scores");
            int start = 0;
            int end = 10;
            int sum = 0;
            Get_sum(start, end, sum);   
        }
       
        private static void Get_sum(int start, int end, int sum)
        {
            start = start + 1;
            Console.WriteLine($"Enter a score between 0 and 100 : ");
            sum += Convert.ToInt32(Console.ReadLine());
            if (start < end)
            {
                Get_sum(start, end, sum);
            }
            else
            {
                Console.WriteLine($"the sum is {sum}");
                int avg = sum / 10;
                Console.WriteLine($"the average is {avg}");
                if (avg >= 90)
                {
                    Console.WriteLine($"Your Grade is  A ");
                }
                else if (avg >= 80)
                {
                    Console.WriteLine($"Your Grade is  B ");
                }
                else if (avg >= 70)
                {
                    Console.WriteLine($"Your Grade is  C ");
                }
                else if (avg >= 60)
                {
                    Console.WriteLine($"Your Grade is  D ");
                }
                else
                {
                    Console.WriteLine($"Your Grade is  F ");
                }
                Console.WriteLine("Part 4: average of any number of scores"); 
               {
                    int total = 0,
                        i = 0;
                    Console.WriteLine(" Enter How many scores you want to compute");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Enter your scores one by one");
                    while (i < n)
                    {
                        int score = Convert.ToInt32(Console.ReadLine());
                        total += score;
                        i++;
                    }
                    Console.WriteLine($"The total of the scores is {total} ");
                    float average = total / n;
                    Console.WriteLine($"The average of the scores is {average} ");
                    if (average >= 90)
                    {
                        Console.WriteLine($"Your Grade is  A ");
                    }
                    else if (average >= 80)
                    {
                        Console.WriteLine($"Your Grade is  B ");
                    }
                    else if (average >= 70)
                    {
                        Console.WriteLine($"Your Grade is  C ");
                    }
                    else if (average >= 60)
                    {
                        Console.WriteLine($"Your Grade is  D ");
                    }
                    else
                    {
                        Console.WriteLine($"Your Grade is  F ");
                        return;
                    }

                    
                }

            }

        }
    }

}           

       
           
       
    
