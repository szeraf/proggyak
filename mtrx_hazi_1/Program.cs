using System;

namespace mtrx_hazi_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] matrix = new int[5,10];
            Random rnd = new Random();
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i,j] = rnd.Next(100,1000);               // fill the matrix with 3 digit integers
                    System.Console.Write(matrix[i,j] + " ");        // echo the element to the console
                    sum += matrix[i,j];                             // summarize the values
                }
                System.Console.WriteLine();
            }

            System.Console.WriteLine("Az elemek átlaga: " + ( sum / ( matrix.GetLength(0) * matrix.GetLength(1) ) ) );
            
            Console.ReadLine();
        }
    }
}
