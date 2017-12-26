using System;

namespace mtrx_hazi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vektor1 = new int[10];
            int[] vektor2 = new int[10];
            int[] vektor3 = new int[10];

            int[] avg = new int[3];
            
            Random rnd = new Random();

            int[,] matrix = new int[3,10];
            
            int temp;

            // 1. vektor feltoltese majd az elemek atlaganak kiszamolasa
            for (int i = 0; i < vektor1.Length ; i++)
            {
                vektor1[i] = rnd.Next(0,101);
                avg[0] += vektor1[i];
            }
            avg[0] /= vektor1.Length;
            
            // 2. vektor feltoltese majd az elemek atlaganak kiszamolasa
            for (int i = 0; i < vektor2.Length ; i++)
            {
                vektor2[i] = rnd.Next(0,101);
                avg[1] += vektor2[i];
            }
            avg[1] /= vektor2.Length;

            // 3. vektor feltoltese majd az elemek atlaganak kiszamolasa
            for (int i = 0; i < vektor3.Length ; i++)
            {
                vektor3[i] = rnd.Next(0,101);
                avg[2] += vektor3[i];
            }
            avg[2] /= vektor3.Length;

            // 1. vektor rendezese
            for (int i = 0; i < vektor1.Length; i++)
            {
                for (int j = i + 1; j < vektor1.Length; j++)
                {
                    if (vektor1[i] > vektor1[j])
                    {
                        // csere
                        temp = vektor1[i];
                        vektor1[i] = vektor1[j];
                        vektor1[j] = temp;
                    }
                }
            // matrix 1. soranak feltoltese
                matrix[0,i] = vektor1[i];
            }

            // 2. vektor rendezese
            for (int i = 0; i < vektor2.Length; i++)
            {
                for (int j = i + 1; j < vektor2.Length; j++)
                {
                    if (vektor2[i] > vektor2[j])
                    {
                        // csere
                        temp = vektor2[i];
                        vektor2[i] = vektor2[j];
                        vektor2[j] = temp;
                    }
                }
            // matrix 2. soranak feltoltese
                matrix[1,i] = vektor2[i];
            }

            // 3. vektor rendezese
            for (int i = 0; i < vektor3.Length; i++)
            {
                for (int j = i + 1; j < vektor3.Length; j++)
                {
                    if (vektor3[i] > vektor3[j])
                    {
                        // csere
                        temp = vektor3[i];
                        vektor3[i] = vektor3[j];
                        vektor3[j] = temp;
                    }
                }
            // matrix 3. soranak feltoltese
                matrix[2,i] = vektor3[i];
            }

            // matrix kiiratasa
            for (int i = 0; i < matrix.GetLength(0); i++)       // sor
            {
                for (int j = 0; j < matrix.GetLength(1); j++)   // oszlop
                {
                    System.Console.Write(((matrix[i,j]<10)?" ":"") + matrix[i,j] + " ");    // pretty print: ha 1 digites a szam akkor elozze meg szokoz
                }
                System.Console.WriteLine(" atlag: " + avg[i]);
            }

            System.Console.WriteLine("Transzponalt matrix:");

            for (int i = 0; i < matrix.GetLength(1); i++)       // oszlop
            {
                for (int j = 0; j < matrix.GetLength(0); j++)   // sor
                {
                    System.Console.Write(((matrix[j,i]<10)?" ":"") + matrix[j,i] + " ");    // a fenti csere miatt j,i a sorrend (sor,oszlop), kulonben tulindexeljuk a tombunket
                }
                System.Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
