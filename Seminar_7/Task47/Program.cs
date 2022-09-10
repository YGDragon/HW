/*
Задача 47.
Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

// Комбинированный метод - задание размера массива и вывод результата.
void OutResult()
{
    double[,] data = new double[5, 6];
    FillArray(data);
    PrintArray(data);
}

// Метод - заполнение массива случайными вещественными числами.
void FillArray(double[,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            double factor = new Random().NextDouble();
            data[i, j] = factor * new Random().Next(-50, 50);
            data[i, j] = Math.Round(data[i, j], 1);
        }
    }
}

// Метод - вывод на печать массива.
void PrintArray(double[,] data)
{
    Console.WriteLine();
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            Console.Write($"{data[i, j]}\t");
        }
        Console.WriteLine('\n');
    }
}

// Вызов комбинированного метода.
OutResult();