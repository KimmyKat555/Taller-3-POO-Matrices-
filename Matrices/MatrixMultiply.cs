using System;

public class MatrixMultiplier
{
    public static void MultiplyMatrices()
    {
        int m, n, p;

        Console.Write("Ingrese el valor de m: ");
        m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el valor de n: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el valor de p: ");
        p = Convert.ToInt32(Console.ReadLine());

        int[,] matrixA = new int[m, n];

        int[,] matrixB = new int[n, p];

        int[,] matrixC = new int[m, p];

        Console.WriteLine("\n*** A ***");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrixA[i, j] = (i + 1) * j;
                Console.Write(matrixA[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n*** B ***");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < p; j++)
            {
                matrixB[i, j] = (j + 1) * i;
                Console.Write(matrixB[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n*** Multiplicando A x B... ***");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < p; j++)
            {
                matrixC[i, j] = 0;
                for (int k = 0; k < n; k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        Console.WriteLine("\n*** C ***");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < p; j++)
            {
                Console.Write(matrixC[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

