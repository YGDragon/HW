/*
Задача 47.
Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] data = new double[4, 4];
GetArray(data);

// Метод - заполнение массива и вывод на печать.
void GetArray(double[,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            double coef = new Random().NextDouble();
            data[i, j] = coef * new Random().Next(-50, 50);
            double mediate = Math.Round(data[i, j], 1);
            // Выравнивание элементов по вертикали.
            string line = String.Empty;
            line = mediate < 0 ? $"{mediate}\t" : $"{line} {mediate}\t";
            Console.Write(line);
        }
        Console.WriteLine('\n');
    }
}
