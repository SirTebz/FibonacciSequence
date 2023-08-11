using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print a General Fibonacci Sequence");
            Console.WriteLine("==================================\n");
            
            
            ////Defensive 1
            //int firstNum = 0;
            //int secondNum = 0;
            //int numTerms = 0;
            
            //Console.Write("Enter the first number of the sequence: ");
            //if (!int.TryParse(Console.ReadLine(), out firstNum))
            //{
            //    Console.WriteLine("Error: only integer values are accepted.");
            //    return;
            //}

            //Console.Write("Enter the second number of the sequence: ");
            //if (!int.TryParse(Console.ReadLine(), out secondNum))
            //{
            //    Console.WriteLine("Error: only integer values are accepted.");
            //    return;
            //}

            //Console.Write("Enter the total number of terms to be displayed: ");
            //if (!int.TryParse(Console.ReadLine(), out numTerms))
            //{
            //    Console.WriteLine("Error: only integer values are accepted.");
            //    return;
            //}

            //PrintFibonacci(firstNum, secondNum, numTerms);

            //Defensive 2
            Console.WriteLine("Print a General Fibonacci Sequence");
            Console.WriteLine("==================================");
            try
            {
                Console.Write("\nEnter the first number in your General Fibonacci sequence:");
                int iFirst = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number in your General Fibonacci sequence: ");
                int iSecond = int.Parse(Console.ReadLine());

                Console.Write("Enter the number of terms in the General Fibonacci sequence:");
                int iNumOfTerms = int.Parse(Console.ReadLine());
                
                PrintFibonacci(iFirst, iSecond, iNumOfTerms);
            }
            catch
            {
                Console.WriteLine("\nInvalid input.\nAll values should be integers.");
            }

            Console.Write("\nPress any key to exit... ");
            Console.ReadKey();
        }

        static int NextFibonacci(ref int num1, ref int num2)
        {
            int sum = num1 + num2;
            num1 = num2;
            num2 = sum;
            return sum;
        }

        static void PrintFibonacci(int num1, int num2, int numTerms)
        {
            if (numTerms < 3)
            {
                Console.WriteLine("Error: number of terms must be at least 3.");
                return;
            }

            Console.Write(num1 + " " + num2 + " ");

            for (int i = 2; i < numTerms; i++)
            {
                int nextNum = NextFibonacci(ref num1, ref num2);
                Console.Write(nextNum + " ");
            }

            Console.WriteLine();
        }
    }
}
