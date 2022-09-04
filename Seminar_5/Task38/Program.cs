/*
Задача 38:
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
// Комбинированный метод - вывод результата.
void QuantityPosNum(double[] inpar)
{
    FillArray(inpar);
    DivMaxMin(inpar, out double max, out double min);
    Console.WriteLine($"max = {max}, min = {min}");
    PrintArray(inpar);
    Console.Write(max - min);
}
// Метод - заполнение массива.
void FillArray(double[] data)
{
    for (int i = 0; i < data.Length; i++)
    {
        data[i] = new Random().Next(100);
    }
}
// Метод - печать массив.
void PrintArray(double[] data)
{
    string line = String.Empty;
    int l = data.Length - 1;
    double last = data[l];
    for (int i = 0; i < l; i++)
    {
        line += $"{data[i]}, ";
    }
    Console.Write("[" + line + $"{last}] -> ");
}
// Метод - вычисление разницы max и min чисел в массиве.
double DivMaxMin(double[] data, out double maxnum, out double minnum)
{
    maxnum = data[0];
    minnum = data[1];
    for (int i = 0; i < data.Length; i++)
    {
        maxnum = data[i] > maxnum ? data[i] : maxnum;
        minnum = data[i] < minnum ? data[i] : minnum;
    }
    return maxnum - minnum;
}
// Определение параметров массива
Console.Write("Необходимо задать размер массива: ");
double[] numd = new double[Convert.ToInt32(Console.ReadLine())];
// Вызов комбинированного метода.
QuantityPosNum(numd);