// sum of n natural numbers 

using System;

namespace sum_of_digits
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("please Enter a number :");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= a; i++)
            {
                sum = sum + i;
                Console.WriteLine(i);
            }
            Console.WriteLine("the sum is = {0}",sum);
        }
    }
}