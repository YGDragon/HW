/*
Задача 27: Напишите программу, которая
принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
// Определение функции вычисления суммы цифр в числе
void SumDigit(int number)
{
    int sum = 0;
    do
    {
        int remnant = number % 10;
        number = number / 10;
        sum = sum + remnant;
    }
    while (number != 0);
    Console.WriteLine($"{sum}");
}
// Входные данные
int[] direct = { 452, 82, 9012 };
// Применение функции последовательно для трех чисел
foreach (int k in direct)
{
    Console.Write($"{k} -> ");
    SumDigit(k);
}