using System;

class Program
{
    static void Main(string[] args)
    {
        int[] szamok = new int[100];

        Console.WriteLine("Kérek max. 100 számot. 0-jelöli a bevitel végét.");
        int bevitel = -1;
        int index = 0;
        int min = Int32.MaxValue; // az iteger-en eltárolható legnagyobb szám
        int max = -1;

        do
        {
            Console.Write("Kérek egy számot: ");
            bevitel = Convert.ToInt32(Console.ReadLine());
            szamok[index] = bevitel;
            index++;

            if (bevitel < min && bevitel > 0)
            {
                min = bevitel;
            }
            if (bevitel > max)
            {
                max = bevitel;
            }

        } while (bevitel != 0);
        
        // kiiras beolvasas sorrendjeben
        index = 0;
        while (szamok[index] != 0)
        {
            Console.Write(szamok[index] + " ");
            index++;
        }
        Console.WriteLine();

        // legkisebb legnagyobb
        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min: " + min);

        // kiiras forditott sorrendben
        for (int i = szamok.Length-1; i >= 0; i--)
        {
            if (szamok[i]!=0)
            {
                Console.Write(szamok[i] + " ");
            }
        }

        Console.ReadLine();
    }
}
