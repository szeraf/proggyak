using System;

namespace cshrp_gyak
{
    class Program
    {
        static void kiir (string nev, int kor){
            Console.WriteLine( nev );
            System.Console.WriteLine( kor );
        }

        static int szuletett(int kor){
            int evszam = 2018 - kor;
            
            return evszam;
        }
        
        static void Main(string[] args)
        {
            System.Console.WriteLine("add meg a neved: ");
            string nev = Console.ReadLine();
            System.Console.WriteLine("add meg a korod: ");
            int kor = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("a neved és a korod: ");
            kiir(nev, kor);

            System.Console.WriteLine(szuletett(kor) + "-ban/ben születtél");

            Console.ReadLine();
        }
    }
}
