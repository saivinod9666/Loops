// right angle triangle with numbers
using System;

namespace rightanglenum
{
    internal class Program11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" {0}", i);
                }
                Console.WriteLine("\n");

            }
        }
    }
}
    
