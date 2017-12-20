using System;

// programozasi tetelek

namespace dec16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[25];
            int osszeg = 0;
            int darab = 0;
            int min;
            int max;
            bool van = false;

            Random r = new Random();

            for (int i = 0; i < szamok.Length; i++){
                szamok[i] = r.Next(1,51);
                System.Console.Write(szamok[i] + " ");
            }
            System.Console.WriteLine();

            // osszegzes tetel
            System.Console.Write("Osszeg: ");
            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];
            }
            System.Console.WriteLine(osszeg);

            // megszamlalas tetele (pl. hany darab >= 25)
            System.Console.Write("Nagyobb mint 25: ");
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] >= 25)
                {
                    darab++;
                }
            }
            System.Console.WriteLine(darab + " db");

            // minimum kivalasztas tetele
            min = szamok[0];
            System.Console.Write("Legkisebb: ");
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] < min)
                {
                    min = szamok[i];
                }
            }
            System.Console.WriteLine(min);

            // maximum kivalasztas tetele
            max = szamok[0];
            System.Console.Write("Legnagyobb: ");
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] > max)
                {
                    max = szamok[i];
                }
            }
            System.Console.WriteLine(max);

            // eldontes tetele (pl. van-e 25 erteku elem)
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] == 25)
                {
                    van = true;
                }
            }
            System.Console.WriteLine("Van-e 25 erteku elem: " + (van?"van":"nincs"));

            // kivalasztas tetele (pl. hanyadik elem a 25, ha van)
            if (van)
            {
                int i = 0;
                while (szamok[i] != 25)
                {
                    i++;
                }
                System.Console.WriteLine("A 25 ertek elso indexe(1. pozicio a 0): " + i);
            }

            // cseres rendezes
            int temp;
            for (int i = 0; i < szamok.Length; i++)
            {
                for (int j = i + 1; j < szamok.Length; j++)
                {
                    if (szamok[i] > szamok[j])
                    {
                        // csere
                        temp = szamok[i];
                        szamok[i] = szamok[j];
                        szamok[j] = temp;
                    }
                }
            }
            for (int i = 0; i < szamok.Length; i++)
            {
                System.Console.Write(szamok[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
