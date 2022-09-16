/*
Задача 62.
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

//Комбинированный метод - вывод результата.
void OutResult()
{
    string[,] spiral = new string[4, 4];
    // Задание зубчатого массива.
    string[][] numbers = {
    new string[] { "01", "02", "03", "04" },
    new string[] { "12", "13", "14", "05" },
    new string[] { "11", "16", "15", "06" },
    new string[] { "10", "09", "08", "07" }
    };
    SpiralFill(spiral, numbers);
    Console.WriteLine();
    Console.WriteLine("Двумерный массив 4 на 4:");
    PrintArray(spiral);
}

// Метод - спиральное заполнение двумерного массива.
void SpiralFill(string[,] data, string[][] filler)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            data[i, j] = filler[i][j];
        }
    }
}

// Метод - вывод на печать двумерного массива.
void PrintArray(string[,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            Console.Write($"{data[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
OutResult();