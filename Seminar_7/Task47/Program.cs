/*
Задача 47.
Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

double[,] data = new double[5, 6];
GetArray(data);

// Метод - заполнение массива случайными вещественными числами.
void GetArray(double[,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            double coef = 1;
            // Исключение вывода -0
            coef = coef == 0 ? -1 : new Random().NextDouble();
            data[i, j] = coef * new Random().Next(-50, 50);
            Console.Write($"{Math.Round(data[i, j], 1)}\t");
        }
        Console.WriteLine('\n');
    }
}