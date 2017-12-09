using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();

        int gondolt = r.Next(20) + 1;
        int tipp = -1;
        int darab = 0;
        Console.WriteLine("Gondoltam egy számot(1-20).");
        do
        {
            Console.Write("Tippelj: ");
            tipp = Convert.ToInt32(Console.ReadLine());
            if (gondolt < tipp)
            {
                Console.WriteLine("A gondolt szám kisebb.");
            }
            else if (gondolt > tipp)
            {
                Console.WriteLine("A gondolt szám nagyobb.");
            }
            darab++;
        } while (gondolt != tipp);

        Console.WriteLine("Grat! ({0} tippet adtál)", darab);

        Console.ReadLine();
    }
}
