/*
Задача 34:
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
// Метод выводящий количество четных элементов в массиве
void QuantityPosNum(int[] par1, int par2)
{
    FillArray(par1);
    PrintArray(par1, par2);
    Console.Write(PosNumbers(par1));
}
// Метод выполняющий заполнение массива
void FillArray(int[] data)
{
    for (int k = 0; k < data.Length; k++)
    {
        data[k] = new Random().Next(100, 1000);
    }
}
// Метод печати массива
void PrintArray(int[] data, int length)
{
    string line = String.Empty;
    int l = length - 1;
    int last = data[l];
    for (int i = 0; i < l; i++)
    {
        line += $"{data[i]}, ";
    }
    Console.Write("[" + line + $"{last}] -> ");
}
// Метод нахождени положительных чисел в массиве
int PosNumbers(int[] data)
{
    int quit = 0;
    foreach (int k in data)
    {
        quit = k % 2 == 0 ? quit + 1 : quit;
    }
    return quit;
}
// Определение параметров массива
Console.Write("Задать размер одномерного массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] number3th = new int[size];
// Вызов метода
QuantityPosNum(number3th, size);