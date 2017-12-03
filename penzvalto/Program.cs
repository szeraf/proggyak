using System;

/*
* Author: Bence Vér
* Date: 03.12.2017.
* Description: money exchange program
*       The program prompts for a money sum (osszeg), then
*       it tries to determine which and how many notes and coins can be given.
*       The program assumes HUF as currency, and rounds up/down for 5 as that is the smallest HUF coin.
*/

namespace sampleproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy összeget:");
            int osszeg = Convert.ToInt32(Console.ReadLine());

            int kerek = osszeg - (osszeg % 5);
            Console.WriteLine("A kerekített összeg: " + kerek);

            int reszosszeg = kerek;
            int darab = 0;
            
            // 20.000
            darab = reszosszeg / 20000;
            if (darab > 0)
            {
                Console.WriteLine(darab + " x 20.000");
                reszosszeg -= (darab * 20000);
            }
            // 10.000
            darab = reszosszeg / 10000;
            if (darab > 0)
            {
                Console.WriteLine(darab + " x 10.000");
                reszosszeg -= (darab * 10000);
            }
            // 5.000
            darab = reszosszeg / 5000;
            if (darab > 0)
            {
                Console.WriteLine(darab + " x 5.000");
                reszosszeg -= (darab * 5000);
            }
            // 2.000
            darab = reszosszeg / 2000;
            if (darab > 0)
            {
                Console.WriteLine(darab + " x 2.000");
                reszosszeg -= (darab * 2000);
            }
            // 1.000
            darab = reszosszeg / 1000;
            if (darab > 0)
            {
                Console.WriteLine(darab + " x 1.000");
                reszosszeg -= (darab * 1000);
            }
            // 500
            darab = reszosszeg / 500;
            if (darab > 0)
            {
                Console.WriteLine(darab + " x 500");
                reszosszeg -= (darab * 500);
            }
            // 200
            darab = reszosszeg / 200;
            if (darab > 0)
            {
                Console.WriteLine(darab + " x 200");
                reszosszeg -= (darab * 200);
            }
            // 100
            darab = reszosszeg / 100;
            if (darab > 0)
            {
                Console.WriteLine(darab + " x 100");
                reszosszeg -= (darab * 100);
            }
            // 50
            darab = reszosszeg / 50;
            if (darab > 0)
            {
                Console.WriteLine(darab + " x 50");
                reszosszeg -= (darab * 50);
            }
            // 20
            darab = reszosszeg / 20;
            if (darab > 0)
            {
                Console.WriteLine(darab + " x 20");
                reszosszeg -= (darab * 20);
            }
            // 10
            darab = reszosszeg / 10;
            if (darab > 0)
            {
                Console.WriteLine(darab + " x 10");
                reszosszeg -= (darab * 10);
            }
            // 5
            darab = reszosszeg / 5;
            if (darab > 0)
            {
                Console.WriteLine(darab + " x 5");
                reszosszeg -= (darab * 5);
            }

            Console.ReadLine();
        }
    }
}
