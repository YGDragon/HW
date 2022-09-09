/*
Задача 52.
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// Комбинированный метод - вывод результата.
void OutResult()
{
    int[,] data = new int[4, 6];
    FillArray(data);
    PrintArray(data);
    MidleSum(data);
}

// Метод - заполнение массива случайными числами.
void FillArray(int[,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            double factor = new Random().NextDouble();
            data[i, j] = new Random().Next(20);
        }
    }
}

// Метод - вывод на печать массива.
void PrintArray(int[,] data)
{
    Console.WriteLine(" ");
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            Console.Write($"{data[i, j]}\t");
        }
        Console.WriteLine('\n');
    }
}

// Метод - вывод среднего арифметического элементов в каждом столбце.
void MidleSum(int[,] data)
{
    int sizeRow = data.GetLength(0);
    int sizeСolumn = data.GetLength(1);
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < sizeСolumn; j++)
    {
        double sum = 0;
        for (int i = 0; i < sizeRow; i++)
        {
            sum += data[i, j];
        }
        sum = Math.Round(sum / sizeRow, 1);
        Console.Write($"{sum}");
        if (j < sizeСolumn - 1)
        {
            Console.Write("; ");
        }
        else
        {
            Console.Write(".");
        }
    }
}

// Вызов комбинированного метода.
OutResult();