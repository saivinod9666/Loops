// patter like right angle triangle with number 
using System;

namespace trianglenum
{
    internal class program10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" {0}",j);
                }
                Console.WriteLine("\n");
            }

        }
    }
}