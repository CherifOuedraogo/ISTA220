/*******************************************
 * Name: C# Exericse 05*********************
 * Author: Cherif Ouedraogo*****************
 * Date: August 5,2019*********************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 2, 4, 6, 8, 10 };
            int[] B = { 1, 3, 5, 7, 9 };
            int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            Console.WriteLine("Computing Array count, sum, average and medium:\n Press any key to continue ");
            Console.ReadLine();
            Console.WriteLine("Array A ");
            ComputeArrays(A);
            Console.WriteLine("Array B ");
            ComputeArrays(B);
            Console.WriteLine("Array C ");
            ComputeArrays(C);
            Console.WriteLine("Rotating Arrays:\n Press Any key to continue");
            Console.ReadLine();
            RotateArrays("Left",2,A);
            RotateArrays("Right", 2, B);
            RotateArrays("Left", 4, C);
            Console.WriteLine("Bubble Sorting Array C:\n Press any key to continue");
            Console.ReadLine();
            BubbleSort(C);

        }
        static void ComputeArrays(int[] Array)
        {
            int Len1 = Array.Length;
            for (int i = 0; i < Len1; i++)
            Console.Write(Array[i]);
           int sum = 0;
           int count = Array.Length;
           Console.WriteLine($"\nThe number of elements is [{count}]");
           for (int i = 0; i < count; i++)
           sum += Array[i];
           count--;
           double Avg = sum / count;
           double  Mean = sum / 2;
           Console.WriteLine($"The Sum is [{sum}] , the Average is [{Avg}] and the Mean is [{Mean}]");
           Console.WriteLine("The reversed Array is ");
           int Len2 = Array.Length;
           for (int j = Len2 - 1; j >= 0; j--)
           Console.Write(Array[j]);
            Console.WriteLine();

        }
         static void RotateArrays(string direction, int numbPlaces, int[] Array)

          {
                Console.WriteLine("Enter the direction you wish to rotate the array: Left or Right ");
                direction = Console.ReadLine();
                    Console.WriteLine("Enter the number of places you wish to rotate the array: ");
                    numbPlaces = Convert.ToInt32(Console.ReadLine());
                    int index = Array.Length;
                    if (direction == "Right")
                        numbPlaces = index - numbPlaces;
                    for (int i = 0; i < index; i++)
                        Console.Write(Array[(i + numbPlaces) % index]);
                    Console.WriteLine();
          }
        private static void BubbleSort(int[] Array)
        {
            Console.WriteLine("The order of Array C before sorting");
            foreach (int e in Array)
                Console.Write(e);
            Console.WriteLine();
            for (int i = 0; i < Array.Length - 1; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        int temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                    }

                }
            }
            Console.WriteLine("Array C sorted ");
            foreach (int e in Array)
                Console.Write(e);
            Console.WriteLine();


        }

    }   
 }

