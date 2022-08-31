/*
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
// Проверка на правильность ввода числа
while (num <= 10000 || num >= 100000)
{
    Console.Write("Введено неверное значение. ");
    Console.Write("Введите пятизначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}
// Проверка последовательно трех чисел на соответствие палиндрому
for (int i = 1; i < 4; i++)
{
    int part1 = Math.DivRem(num, 10, out int d5); // Нахождение значений всех цифр в числе
    int part2 = Math.DivRem(part1, 10, out int d4);
    int part3 = Math.DivRem(part2, 10, out int d3);
    int d1 = Math.DivRem(part3, 10, out int d2);
    if (d4 == d2 && d5 == d1) // Условие проверки на соответствие палиндрому
    {
        Console.WriteLine($"{num} -> да");
    }
    else
    {
        Console.WriteLine($"{num} -> нет");
    }
    // Условие прерывания ввода следующего числа
    if (i == 3)
    {
        break;
    }
    Console.Write("Введите слудующее пятизначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}