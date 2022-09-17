/*
Задача 58: Задайте две матрицы.
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

void OutResult()
{
    int[,] matrix1 = new int[3, 2];
    int[,] matrix2 = new int[2, 3];
    FillArray(matrix1);
    FillArray(matrix2);
    Console.WriteLine("Заданные матрицы: ");
    PrintArray(matrix1);
    PrintArray(matrix2);
    int[,] matrix3 = MatrixProduct(matrix1, matrix2);
    PrintArray(matrix3);
}

// Метод - умножение первой матрицы на вторую.
int[,] MatrixProduct(int[,] m1, int[,] m2)
{
    int row = m1.GetLength(0);
    int col = m2.GetLength(1);
    int gen = m1.GetLength(1);
    int[,] product = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int l = 0; l < col; l++)
        {
            for (int k = 0; k < col; k++)
            {
                int sum = 0;
                for (int j = 0; j < gen; j++)
                {
                    sum += m1[i, j] * m2[j, l];
                }
                product[i, l] = sum;
            }
        }
    }
    Console.WriteLine();
    return product;
}

// Метод - заполнение двумерного массива.
void FillArray(int[,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            data[i, j] = new Random().Next(-4, 4);
        }
    }
}

// Метод - вывод на печать двумерного массива.
void PrintArray(int[,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            if (data[i, j] >= 0)
            {
                Console.Write(" " + $"{data[i, j]}\t");
            }
            else
            {
                Console.Write($"{data[i, j]}\t");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
OutResult();