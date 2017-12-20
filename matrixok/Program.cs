using System;

namespace matrixok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4,2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write("Add meg a {0}. sor {1}. elemet: ", i+1, j+1);
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write(matrix[i,j] + " ");
                }
                System.Console.WriteLine();
            }
            
            // transzponalas
            int[,] transzp = new int[2,4];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    transzp[j,i] = matrix[i,j];
                }
            }

            System.Console.WriteLine("Transzponalt matrix:");
            for (int i = 0; i < transzp.GetLength(0); i++)
            {
                for (int j = 0; j < transzp.GetLength(1); j++)
                {
                    System.Console.Write(transzp[i,j] + " ");
                }
                System.Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
