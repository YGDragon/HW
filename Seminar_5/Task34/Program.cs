/*
Задача 34:
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
// Комбинированный метод - вывод результата.
void QuantityPosNum(int[] par1)
{
    FillArray(par1);
    PrintArray(par1);
    Console.Write(PosNumbers(par1));
}
// Метод выполняющий заполнение массива
void FillArray(int[] data)
{
    for (int i = 0; i < data.Length; i++)
    {
        data[i] = new Random().Next(100, 1000);
    }
}
// Метод печати массива
void PrintArray(int[] data)
{
    string line = String.Empty;
    int l = data.Length - 1;
    int last = data[l];
    for (int i = 0; i < l; i++)
    {
        line += $"{data[i]}, ";
    }
    Console.Write("[" + line + $"{last}] -> ");
}
// Метод - нахождение положительных чисел в массиве.
int PosNumbers(int[] data)
{
    int quit = 0;
    foreach (int k in data)
    {
        quit += k % 2 == 0 ? 1 : 0;
    }
    return quit; 
}
// Определение параметров массива.
Console.Write("Задать размер одномерного массива: ");
int[] number3th = new int[Convert.ToInt32(Console.ReadLine())];
// Вызов комбинированного метода.
QuantityPosNum(number3th);