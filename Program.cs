using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[10, 10];
        Random random = new Random();
        int minValue = 0;
        int maxValue = 10;
        int maxElement = int.MinValue;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = random.Next(minValue, maxValue);
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write(matrix[i, j] + " ");

            Console.WriteLine();
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > maxElement)
                    maxElement = matrix[i, j];
            }
        }

        Console.WriteLine();
        Console.WriteLine("Максимальный элемент матрицы: " + maxElement);
        Console.WriteLine();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == maxElement)
                    matrix[i, j] = 0;

                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}
