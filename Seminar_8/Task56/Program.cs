/*
Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

// Комбинированный метод - вывод результата.
void OutResult()
{
    int[,] table = new int[7, 3];
    Console.WriteLine("Заданный массив: ");
    GetArray(table);
    int result = CheckSum(table);
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result}");
}

// Метод №1 - заполнение двумерного массива и вывод на печать.
void GetArray(int[,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            data[i, j] = new Random().Next(20);
            Console.Write($"{data[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Метод №2 - вывод на печать одномерного массива.
void PrintArray(int[] data)
{
    for (int i = 0; i < data.Length; i++)
    {
        Console.Write($"строка {i + 1} -> {data[i]}\n");
    }
    Console.WriteLine();
}

// Метод №3 - проверка суммы элементов строк массива.
int CheckSum(int[,] data)
{
    int row = data.GetLength(0);
    int[] arraySum = new int[row];
    for (int i = 0; i < row; i++)
    {
        int sum = 0;
        for (int j = 0; j < data.GetLength(1); j++)
        {
            sum += data[i, j];
        }
        arraySum[i] = sum;
    }
    Console.WriteLine("Построчные суммы: ");
    PrintArray(arraySum);
    int minRow = MinValue(arraySum);
    return minRow;
}

// Метод №4 - поиск номера строки с наименьшей суммой.
int MinValue(int[] oneRow)
{
    int min = oneRow[0];
    int count = 1;
    for (int i = 1; i < oneRow.Length; i++)
    {
        if (oneRow[i] < min)
        {
            min = oneRow[i];
            count = i + 1;
        }
    }
    return count;
}

OutResult();
