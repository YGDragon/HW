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
    int[,] data = new int[4, 4];
    GetArray(data);
    MidleSum(data);
}

// Метод - заполнение массива и вывод на печать.
void GetArray(int[,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            data[i, j] = new Random().Next(20);
            Console.Write($"{data[i, j]}\t");
        }
        Console.WriteLine('\n');
    }
}

// Метод - вывод среднего арифметического элементов в каждом столбце.
void MidleSum(int[,] data)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int row = data.GetLength(0);
    int column = data.GetLength(1);
    for (int j = 0; j < column; j++)
    {
        double sum = 0;
        for (int i = 0; i < row; i++)
        {
            sum += data[i, j];
        }
        Console.Write(Math.Round(sum / row, 1));
        string end = j < column - 1 ? "; " : ".";
        Console.Write(end);
    }
}

// Вызов комбинированного метода.
OutResult();
