// multile tables 
using System;
namespace multiple_tables
{
    internal class Program7
    {
        static void Main(string[] args)
        {
            Console.Write("which table do you want : ");
            int a = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
                Console.WriteLine("\n");

            }


        }
    }
}