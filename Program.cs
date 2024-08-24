using System;

namespace TaskJunior3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumSecondLine = 0;
            int sumFirstColumm = 1;

            int [,] matrix = new int[2, 3] {
                {9, 8, 7},
                {6, 5, 4},
            };

            Console.WriteLine(matrix.Length + "- кол-во элементов в самой матрице.\n\nМатрица: \n");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(matrix[i, 0] + " ");
                sumFirstColumm *= matrix[i, 0];
            }

            Console.Write($" = {sumFirstColumm} - произведение первого столбца.\n");

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[0, j] + " ");
                sumSecondLine += matrix[0, j];
            }

            Console.Write($" = {sumSecondLine} - сумма второй строки.\n");
        }
    }
}
