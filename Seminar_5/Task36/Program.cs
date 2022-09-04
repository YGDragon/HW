/*Задача 36:
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
// Комбинированный метод - вывод результата.
void QuantityPosNum(int[] inpar)
{
    FillArray(inpar);
    PrintArray(inpar);
    Console.Write(SumNegative(inpar));
}
// Метод - заполнение массива.
void FillArray(int[] data)
{
    for (int i = 0; i < data.Length; i++)
    {
        data[i] = new Random().Next(-100, 100);
    }
}
// Метод - печать массива.
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
// Метод - нахождение суммы значений нечетных элементов в массиве.
int SumNegative(int[] data)
{
    int sumneg = 0;
    for (int i = 0; i < data.Length; i++)
    {
        sumneg += i % 2 != 0 ? data[i] : 0;
    }
    return sumneg;
}
// Определение параметров массива.
Console.Write("Необходимо задать размер массива: ");
int[] numd = new int[Convert.ToInt32(Console.ReadLine())];
// Вызов комбинированного метода.
QuantityPosNum(numd);