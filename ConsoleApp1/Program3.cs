// n terms of natural numbers and their sum 

using System;

namespace ConsoleApp1
{
    internal class Program3
    {
        static void Main(string[] args)
        {

            
            int sum = 0;
            int a = 0;
            Console.WriteLine("please Enter fitst 5 natural numbers;");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("please enter a number ");
                 a = Convert.ToInt32(Console.ReadLine());

                sum = sum + a;
                
            }
            Console.WriteLine("the sum is = {0}", sum);


        }
    }
}