using System;

namespace matrixfeltolt
{
    class Program
    {
        static int beolvas(){
            System.Console.Write("Adj meg egy értéket: ");
            int ertek = Convert.ToInt32(Console.ReadLine());
            return ertek;
        }

        static int[,] matrix_letrehoz(int sor, int oszlop){
            int[,] matrix = new int[sor,oszlop];
            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    matrix[i,j] = Int32.MinValue;
                }
            }
            return matrix;
        }

        static void matrix_feltolt(int[,] matrix, int ertek, int sor, int oszlop){
            matrix[sor,oszlop] = ertek;
        }
        
        static void matrix_kiir(int[,] matrix){
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] != Int32.MinValue ) System.Console.Write(matrix[i,j] + " ");
                }
                System.Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Add meg a mátrix dimenzióit!");
            System.Console.Write("Sor: ");
            int sor = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Oszlop: ");
            int oszlop = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = matrix_letrehoz(sor,oszlop);

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    matrix_kiir(matrix);
                    int ertek = beolvas();
                    matrix_feltolt(matrix,ertek,i,j);
                    Console.Clear();
                }
            }

            matrix_kiir(matrix);

            Console.ReadLine();
        }
    }
}
