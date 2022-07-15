// sum of numband average 
using System;

namespace sum_average
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int a = 0;
            int avg = 0;
            Console.WriteLine("please Enter fitst 5 natural numbers;");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("please enter {0} number ",i);
                a = Convert.ToInt32(Console.ReadLine());

                sum = sum + a;

            }
            Console.WriteLine("the sum is = {0}", sum);
            avg = sum / 5;
            Console.WriteLine("the average is : {0}",avg);




        }
    }
}