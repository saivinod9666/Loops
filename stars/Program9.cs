// off dimond
using System;

namespace stars
{
    internal class Program9
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please enter a number ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                for (int l = 1; l <= i; l++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
                //comment in first commit
            }



                for (int i = 1;  i<= a; i++)
                {
                    for (int j = 1; j<= i; j++)
                    {
                        Console.Write("  ");
                    }
                    for (int k = a; k >=i; k--)
                    {
                        Console.Write("* ");
                    }
                    for (int l = a; l >= i; l--)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine("\n");
                }

            
        }
    }
}
