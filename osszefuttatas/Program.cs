using System;

namespace osszefuttatas
{
    class Program
    {
        static void feltolt(int[] tomb){
            Random rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(1,1001);
            }
            Array.Sort(tomb); // rendezzük a tomb elemeit
        }

        static void kiir(int[] tomb){
            for (int i = 0; i < tomb.Length; i++)
            {
                System.Console.Write(tomb[i] + " ");
            }
            System.Console.WriteLine();
        }
        static int[] osszefuttatas(int[] tomb1, int[] tomb2){
            int index = 0;
            int j = 0;
            int k = 0;
            int[] eredmenytomb = new int[tomb1.Length + tomb2.Length - 2]; // -2 a két plusz hozzáadott elem miatt
            
            while (index < eredmenytomb.Length)
            {
                while (index < eredmenytomb.Length && tomb1[j] < tomb2[k])
                {
                    eredmenytomb[index] = tomb1[j];
                    j++;
                    index++;
                }
                while (index < eredmenytomb.Length && tomb2[k] <= tomb1[j])
                {
                    eredmenytomb[index] = tomb2[k];
                    k++;
                    index++;
                }
            }

            return eredmenytomb;
        }

        static void Main(string[] args)
        {
            // Adott két rendezett sorozat(tömb), szeretnénk megkapni azt a rendezett tömböt,
            // ami mindkét sorozat elemeit rendezetten tartalmazza.

            int[] tomb1 = new int[10];
            feltolt(tomb1);
            System.Console.WriteLine("tomb1:");
            kiir(tomb1);
            // a tömböt kibővítjük egy elemmel,
            // hogy az összefuttatásnál elkerüljük a túlindexelést
            Array.Resize(ref tomb1,tomb1.Length+1);
            // a plusz elem legyen a 32 biten tárolható max integer érték
            tomb1.SetValue(Int32.MaxValue, tomb1.Length-1);

            int[] tomb2 = new int[10];
            feltolt(tomb2);
            System.Console.WriteLine("tomb2");
            kiir(tomb2);
            // a tömböt kibővítjük egy elemmel,
            // hogy az összefuttatásnál elkerüljük a túlindexelést
            Array.Resize(ref tomb2,tomb2.Length+1);
            // a plusz elem legyen a 32 biten tárolható max integer érték
            tomb2.SetValue(Int32.MaxValue, tomb2.Length-1);

            int[] osszefut = new int[tomb1.Length + tomb2.Length];

            // a két tömb összefuttatása
            osszefut = osszefuttatas(tomb1, tomb2);
            
            System.Console.WriteLine("Eredménytömb:");
            kiir(osszefut);

            Console.ReadLine();
        }
    }
}
