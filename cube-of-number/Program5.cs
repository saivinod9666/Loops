// cude of number 
using System;

namespace cube_of_number
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please Enter a number ");
            int a = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine("cube of a number  {0} is = {1} ", i,i*i*i);

            }
        }

    }
}