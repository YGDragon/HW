/*
Задача 25: Напишите цикл, который
принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
// Определение функции возведения в степень
void DegreNum(int par1, int par2)
{
    int k = par1;
    for (int i = 1; i < par2; i++)
    {
        par1 = par1 * k;
    }
    Console.Write($"{par1}");
}
// Входные данные
Console.Write("Введи число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
// Вызов функции
Console.Write($"{numA}, {numB} -> ");
DegreNum(numA, numB);