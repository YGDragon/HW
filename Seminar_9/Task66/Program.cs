/*
Задача 66: Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int numberM = 1;
int numberN = 10;
int sum = SumElements(numberM, numberN);
Console.Write($"M = {numberM}; N = {numberN} -> {sum}");
int SumElements(int n1, int n2)
{
    if (n1 == n2)
    {
        return n1;
    }
    return (n1 + SumElements(n1 + 1, n2));
}