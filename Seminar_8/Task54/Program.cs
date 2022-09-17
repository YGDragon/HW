/*
Задача 54: Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// Комбинированный метод - вывод результата.
void OutResult()
{
    int[,] table = new int[4, 4];
    Console.WriteLine("Заданный массив: ");
    FillArray(table);
    PrintArray(table);
    Console.WriteLine("Упорядоченный массив: ");
    int[,] tableSort = SortEachRow(table);
    PrintArray(tableSort);
}

// Метод - заполнение двумерного массива.
void FillArray(int[,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            data[i, j] = new Random().Next(20);
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
            Console.Write($"{data[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Метод - упорядочивание элементов каждой строки двумерного массива.
int[,] SortEachRow(int[,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        int[] oneRow = new int[data.GetLength(1)];
        for (int j = 0; j < data.GetLength(1); j++)
        {
            oneRow[j] = data[i, j];
        }
        SortArray(oneRow);
        for (int j = 0; j < data.GetLength(1); j++)
        {
            data[i, j] = oneRow[j];
        }
    }
    return data;
}

// Метод - сортировка одномерного массива.
void SortArray(int[] oneRow)
{
    for (int i = 0; i < oneRow.Length; i++)
    {
        for (int j = i + 1; j < oneRow.Length; j++)
        {
            if (oneRow[i] < oneRow[j])
            {
                int value = oneRow[i];
                oneRow[i] = oneRow[j];
                oneRow[j] = value;
            }
        }
    }
}

OutResult();
