//pattern like right angle tryangle with increasing numbers 
using System;


namespace triangle_increaseing_numbers
{
    internal class Program12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number ");
            int a = Convert.ToInt32(Console.ReadLine());
            int k = 1;

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" {0}", k++);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
    
