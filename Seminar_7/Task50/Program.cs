/*
Задача 50.
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2

5 9 2 3

8 4 2 4
17 -> такого числа в массиве нет 
*/

// Комбинированный метод - вывод результата.
void OutResult()
{
    int[,] data = new int[4, 4];
    GetArray(data);
    Console.Write("Введите позицию элемента двумерного массива: ");
    int position = Convert.ToInt32(Console.ReadLine());
    СheckPosition(data, position);
}

// Метод - заполнение массива случайными числами и вывод на печать.
void GetArray(int[,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            data[i, j] = new Random().Next(40);
            Console.Write($"{data[i, j]}\t");
        }
        Console.WriteLine('\n');
    }
}

// Метод - вывод значения элемента в массиве.
void СheckPosition(int[,] data, int inputPar)
{
    int count = -1;
    if (inputPar > data.Length - 1)
    {
        Console.Write($"{inputPar} -> такого числа в массиве нет");
    }
    foreach (int k in data)
    {
        count++;
        if (count == inputPar)
        {
            Console.Write(inputPar + "->" + k);
        }
    }
}

// Вызов комбинированного метода.
OutResult();