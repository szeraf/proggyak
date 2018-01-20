using System;

namespace jan20
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Add meg a telefonszamod: ");
            string telszam = Console.ReadLine();

            string elsoketto = telszam.Substring(0,2);
            string elsonegy = telszam.Substring(0,4);
            if (elsoketto == "06")
            {
                telszam = "+36" + telszam.Substring(2);
            }
            else if (elsonegy == "0036")
            {
                telszam = "+36" + telszam.Substring(4);
            }

            int perhely = telszam.IndexOf("/");
            if (perhely != (-1))
            {
                telszam = telszam.Replace("/","");
                telszam = telszam.Replace("(","");
                telszam = telszam.Replace(")","");
                telszam = telszam.Replace(" ","");
                telszam = telszam.Replace("-","");
            }

            if (telszam.Length == 9 || telszam.Length == 8)
            {
                telszam = "+36" + telszam;
            }

            telszam = telszam.Insert(5,"/");
            System.Console.WriteLine(telszam);
            telszam = telszam.Remove(5,1);

            System.Console.WriteLine(telszam);

            if (telszam.Contains("+361"))
            {
                System.Console.WriteLine("budapesti");
            }else
            {
                System.Console.WriteLine("nem budapesti");
            }

            string evszakok = "tavasz,nyar,osz,tel";
            string[] evszakokT = evszakok.Split(',');
            System.Console.WriteLine(evszakokT[2]);

            Console.ReadLine();
        }
    }
}
