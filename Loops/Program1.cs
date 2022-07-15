// n natural numbers 

using System;

namespace Loops
{
    internal class Program1
    {
        static void Main()
        {
            Console.Write("please Enter a number :");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= a; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}