using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hany soros legyen a haromszog?");
            int sorok = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            for (int i = 0; i < sorok; i++)
            {
                for (int j = sorok-i-1 ; j > 0 ; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < n; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                n+=2;
            }
            Console.ReadLine();
        }
    }
}
