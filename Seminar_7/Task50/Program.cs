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
    FillArray(data);
    PrintArray(data);
    Console.Write("Введите позицию элемента двумерного массива: ");
    int number = Convert.ToInt32(Console.ReadLine());
    СheckPosition(data, number);
}

// Метод - заполнение массива случайными числами.
void FillArray(int[,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            double factor = new Random().NextDouble();
            data[i, j] = new Random().Next(40);
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

// Метод - вывод значения элемента в массиве.
void СheckPosition(int[,] data, int inputPar)
{
    if (inputPar > data.Length - 1)
    {
        Console.Write($"{inputPar} -> такого числа в массиве нет");
    }
    int posNumber = -1;
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            posNumber++;
            if (posNumber == inputPar)
            {
                Console.Write($"{inputPar} -> {data[i, j]}");
            }
        }
    }

}

// Вызов комбинированного метода.
OutResult();