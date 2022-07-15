// odd numbers 
using System;

namespace odd_numbers
{
    internal class Program8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number upto odd number do you want");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("please Enter fitst 5 natural numbers;");
            for (int i = 1; i <= a; i=i+2)
            { 

                sum = sum + i;
                Console.WriteLine(i);

            }
            Console.WriteLine("the sum odd numbers  is = {0}", sum);
           

        }
    }
}