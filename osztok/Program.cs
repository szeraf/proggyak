using System;
using System.IO;

namespace osztok
{
    class Program
    {
        static void Main(string[] args)
        {
            // FileMode: Create(felülír), CreateNew(ha már létezik error), Append(hozzáfűz) -- csak írható
            //           Open(csak olvasható)
            //           OpenOrCreate(írható és olvasható)
            FileStream fs1 = new FileStream("kimenet.txt",FileMode.Create);
            StreamWriter sw1 = new StreamWriter(fs1);

            System.Console.Write("Az elso hany termeszetes szam valodi osztoit szamoljam ki? ");
            int darab = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= darab; i++)
            {
                sw1.Write(i + ": ");
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sw1.Write(j + " ");
                    }
                }
                sw1.WriteLine();
            }

            sw1.Close();
            fs1.Close();

            //Console.ReadLine();
        }
    }
}
