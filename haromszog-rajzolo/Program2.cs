using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hany soros legyen a haromszog?");
            int sorok = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sorok; i++)
            {
                for (int j = sorok-i ; j > 0 ; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (i*2)-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
