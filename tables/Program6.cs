// multiplication of the given integer 

namespace tables
{
    internal class Program6
    {
        static void Main(string[] args)
        {
            Console.Write("which table do you want : ");
            int a = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",a,i,a*i);

            }
        }
    }
}