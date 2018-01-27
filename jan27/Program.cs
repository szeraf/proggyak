using System;
using System.IO;

namespace jan27
{
    // filekezelés
    
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs1 = new FileStream("bemenet.txt",FileMode.Open);
            StreamReader sr1 = new StreamReader(fs1);

            int sorszam = 1;

            while (!sr1.EndOfStream)
            {
                System.Console.WriteLine(sorszam + ".sor: "+ sr1.ReadLine());
                sorszam++;
            }

            sr1.Close();
            fs1.Close();
            
            // FileMode: Create(felülír), CreateNew(ha már létezik error), Append(hozzáfűz) -- csak írható
            //           Open(csak olvasható)
            //           OpenOrCreate(írható és olvasható)
            FileStream fs2 = new FileStream("kimenet.txt",FileMode.Create);
            StreamWriter sw1 = new StreamWriter(fs2);

            for (int i = 1; i <= 100; i++)
            {
                sw1.Write(i + " ");
            }

            sw1.Close();
            fs2.Close();

            Console.ReadLine();
        }
    }
}
