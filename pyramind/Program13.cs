// peramind with increasing number
using System;

namespace pyramind
{
    internal class Program13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number ");
            int a = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\n");


            }
        }
    }
}
    
