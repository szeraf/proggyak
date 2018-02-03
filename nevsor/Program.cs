using System;
using System.IO;

namespace nevsor
{
    class Program
    {
        static int beolvas(string filename){
            StreamReader sr = new StreamReader(filename);
            
            int i = 0;
            string temp;
            string[] splitted = new string[2];
            while (!sr.EndOfStream)
            {
                temp = sr.ReadLine();
                splitted = temp.Split(", ");
                nevsor[i,0] = splitted[0];
                nevsor[i,1] = splitted[1];
                i++;
            }
            sr.Close();

            return i;
        }
        
        // menü kiiratása konzolra
        static void menu(){
            System.Console.WriteLine();
            System.Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine("(1) Listázás");
            System.Console.WriteLine("(2) Új név hozzáadása");
            System.Console.WriteLine("(3) Név tőrlése");
            System.Console.WriteLine("(4) Kilépés");
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine();
            System.Console.Write("Választott menüpont: ");
        }

        static void listazas(){
            int i = 0;
            while (i < lastindex)
            {
                System.Console.WriteLine("(" + (i+1) + ") " + nevsor[i,0] + " " + nevsor[i,1]);
                i++;
            }
        }

        static void ujnev(string nev, string szulev){
            if (lastindex < nevsor.GetLength(0)-1)
            {
                nevsor[lastindex,0] = nev;
                nevsor[lastindex,1] = szulev;

                lastindex++;
                rendezes();
            }
        }

        static void torles(int sorszam){
            if (sorszam <= 100 && sorszam > 0)
            {
                nevsor[sorszam,1] = "9999.99.99";
                System.Console.WriteLine("Toroltem {0}-t a nevsorbol!", nevsor[sorszam,0]);
                rendezes();
                lastindex--;
            }
        }

        // beszuro rendezes
        static void rendezes(){
            int j;
            string[] temp = new string[2];

            for (int i = 1; i < lastindex; i++)
            {
                j = i -1;
                temp[0] = nevsor[i,0];
                temp[1] = nevsor[i,1];

                // string.compare < 0, ha temp alfanumerikusan kisebb mint nevsor[j,1]
                while (j >= 1 && String.Compare(temp[1],nevsor[j,1]) < 0)
                {
                    nevsor[j+1,0] = nevsor[j,0];
                    nevsor[j+1,1] = nevsor[j,1];
                    j--;
                }
                nevsor[j+1,0] = temp[0];
                nevsor[j+1,1] = temp[1];
            }
        }

        static void fajlbair(string filename){
            StreamWriter sw = new StreamWriter(filename, false);
            int i = 0;
            while (i < lastindex)
            {
                sw.WriteLine(nevsor[i,0] + ", " + nevsor[i,1]);
                i++;
            }
            sw.Flush();
            sw.Close();
        }
        
        static string[,] nevsor = new string[100,2];
        static int lastindex = -1;

        static void Main(string[] args)
        {
            // FileMode: Create(felülír), CreateNew(ha már létezik error), Append(hozzáfűz) -- csak írható
            //           Open(csak olvasható)
            //           OpenOrCreate(írható és olvasható)
            //FileStream fs = new FileStream("nevsor.txt",FileMode.OpenOrCreate);
            lastindex = beolvas("nevsor.txt");

            do
            {
                Console.Clear();
                menu();
                string menupont = Console.ReadLine();

                System.Console.ForegroundColor = ConsoleColor.DarkCyan;
                // megfelelő menüpont végrehajtása, eredmény kiiratása
                switch (menupont)
                {
                    case "1":
                        if(lastindex == -1){
                            System.Console.WriteLine("A nevsor ures.");
                        }else{
                            listazas();
                        }
                        break;
                    case "2":
                        System.Console.Write("Nev: ");
                        string nev = Console.ReadLine();
                        System.Console.Write("Szuletesi ido: ");
                        string szulido = Console.ReadLine();
                        ujnev(nev,szulido);
                        break;
                    case "3":
                        System.Console.WriteLine("Hanyadik elemet toroljuk? ");
                        listazas();
                        int index = Convert.ToInt32(Console.ReadLine());
                        if (index > 0 && index <= lastindex) { torles(index-1); }
                        else {System.Console.WriteLine("Torles megszakitva!");}
                        break;
                    case "4":
                        fajlbair("nevsor.txt");
                        return;
                    default:
                        System.Console.WriteLine("Nem értelmezhető választás!");
                        break;
                }

                System.Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Üss entert a folytatáshoz!");
                Console.ReadLine();
            } while (true);
        }
    }
}
