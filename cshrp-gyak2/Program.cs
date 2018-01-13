using System;

namespace cshrp_gyak2
{
    class Program
    {
        static void feltolt(int[] vektor, bool rand){
            Random rnd = new Random();
            for (int i = 0; i < vektor.Length; i++)
            {
                if(rand)
                {
                    vektor[i] = rnd.Next(1,50);
                }
                else
                {
                    vektor[i] = -1;
                }
            }
        }

        static void kiir(int[] vektor){
            if(vektor[0] == -1)System.Console.WriteLine("-");

            for (int i = 0; i < vektor.Length; i++)
            {
                if(vektor[i]!=(-1)){System.Console.Write(vektor[i] + " ");}
            }
            System.Console.WriteLine();
        }

        static void menu(){
            System.Console.WriteLine();
            System.Console.WriteLine("(1) Vektor elemeinek összege és átlaga");
            System.Console.WriteLine("(2) Vektor legkisebb és legnagyobb eleme");
            System.Console.WriteLine("(3) 25-ös szám indexei");
            System.Console.WriteLine("(4) felhasználó által beírt szám hányszor szerepel");
            System.Console.WriteLine("(5) Kilépés");
            System.Console.WriteLine();
            System.Console.Write("Választott menüpont: ");

        }

        static int szum(int[] vektor){
            int sum = 0;
            for (int i = 0; i < vektor.Length; i++)
            {
                sum += vektor[i];
            }
            return sum;
        }

        static int atlag(int[] vektor){
            return szum(vektor)/vektor.Length;
        }

        static int[] minmax(int[] vektor){
            int min = vektor[0];
            int max = vektor[0];

            int[] valasz = new int[2];

            for (int i = 0; i < vektor.Length; i++)
            {
                if (vektor[i] < min)
                {
                    min = vektor[i];
                }
                if (vektor[i] > max)
                {
                    max = vektor[i];
                }
            }
            valasz[0] = min;
            valasz[1] = max;
            return valasz;
        }

        static int[] indexek(int[] vektor, int szam){
            int[] index = new int[vektor.Length];
            feltolt(index, false);
            int idx = 0;
            for (int i = 0; i < vektor.Length; i++)
            {
                if (vektor[i]==szam)
                {
                    index[idx] = i+1;
                    idx++;
                }
            }
            return index;
        }

        static int darab(int[] vektor, int szam){
            int[] tomb = indexek(vektor,szam);
            int darab = 0;
            int i = 0;
            while (tomb[i] != -1)
            {
                darab ++;
                i++;
            }
            return darab;
        } 
        
        static void Main(string[] args)
        {
            int[] vektor = new int[25];
            feltolt(vektor, true);
            do{
                Console.Clear();
                kiir(vektor);
                menu();
                string menupont = Console.ReadLine();
                switch (menupont)
                {
                    case "1":
                        System.Console.WriteLine("Elemek összege: " + szum(vektor));
                        System.Console.WriteLine("Elemek átlaga: " + atlag(vektor));
                        break;
                    case "2":
                        System.Console.WriteLine("Legkisebb elem: " + minmax(vektor)[0]);
                        System.Console.WriteLine("Legnagyobb elem: " + minmax(vektor)[1]);
                        break;
                    case "3":
                        System.Console.WriteLine("A 25-ös szám indexei: ");
                        kiir(indexek(vektor, 25));
                        break;
                    case "4":
                        System.Console.Write("Kérek egy sztámot: ");
                        int szam = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("A megadott szám {0} példányban szerepel a vektorban.", darab(vektor,szam));
                        break;
                    case "5":
                        return;
                    default:
                        System.Console.WriteLine("Nem értelmezhető választás!");
                        break;
                }
                System.Console.WriteLine("Üss entert a folytatáshoz!");
                Console.ReadLine();
            }while(true);
        }
    }
}
