/*
Задача 29: Напишите программу, которая
задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
// Определение функции задания массива
void NumberArray()
{
    int[] num = new int[8];
    string line = String.Empty;
    for (int i = 0; i < 7; i++)
    {
        num[i] = new Random().Next(1, 40);
        line = line + $"{num[i]}, ";
    }
    num[7] = new Random().Next(1, 40);
    line = line + $"{num[7]}";
    Console.Write(line + " -> [" + line + "]");
}
// Вызов функции
NumberArray();