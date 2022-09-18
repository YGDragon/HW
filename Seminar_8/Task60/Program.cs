/*
Задача 60.
...Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет
построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

//Комбинированный метод - вывод результата.
void OutResult()
{
    int[,,] array3 = new int[4, 4, 3];
    Console.WriteLine($"Размер массива: {array3.GetLength(0)} x {array3.GetLength(1)} x {array3.GetLength(2)}");
    FillOriginalArray(array3);
    PrintOriginalArray(array3);
}
// Метод №1 - заполнение трехмерного массива.
void FillOriginalArray(int[,,] data)
{

    for (int g = 0; g < data.GetLength(2); g++)
    {
        int coef = 11;
        coef += g * data.GetLength(0) *data.GetLength(1);
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                data[i, j, g] = coef;
                coef++;
            }
        }
    }
}

// Метод №2 - вывод на печать трехмерного массива.
void PrintOriginalArray(int[,,] data)
{
    for (int g = 0; g < data.GetLength(2); g++)
    {
        Console.WriteLine($"Слой массива №{g + 1}:");
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                string line = $"{data[i, j, g]}" + "(" + $"{i},{j},{g}" + ")  ";
                Console.Write(line);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

OutResult();
