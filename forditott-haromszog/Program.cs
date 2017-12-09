using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hany soros legyen a haromszog?");
        int sorok = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= sorok; i++)
        {
            for (int j = 0; j < i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int k = (sorok - i)*2; k >= 0; k--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
