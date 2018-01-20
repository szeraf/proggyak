using System;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Kerek egy mondatot: ");
            string be = Console.ReadLine();

            be = be.ToLower();

            be = be.Replace(" ","");
            be = be.Replace(".","");
            be = be.Replace(",","");
            be = be.Replace("!","");
            be = be.Replace("?","");

            bool pali = true;
            for (int i = 0; i < be.Length/2; i++)
            {
                if (be[i] != be[be.Length-i-1]) pali = false;
            }

            if (pali)
            {
                System.Console.WriteLine("Palindrom.");
            }
            else
            {
                System.Console.WriteLine("Nem palindrom.");
            }

            Console.ReadLine();
        }
    }
}
