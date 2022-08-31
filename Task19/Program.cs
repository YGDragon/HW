/*
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
// Проверка последовательно трех чисел на соответствие палиндрому
int [] num = {14212,12821,23432};
foreach (int k in num)
{
    int part1 = Math.DivRem(k, 10, out int d5); // Нахождение значений всех цифр в числе
    int part2 = Math.DivRem(part1, 10, out int d4);
    int part3 = Math.DivRem(part2, 10, out int d3);
    int d1 = Math.DivRem(part3, 10, out int d2);
    if (d5 == d1 && d4 == d2) // Условие проверки на соответствие палиндрому
    {
        Console.WriteLine($"{k} -> да");
    }
     else
    {
        Console.WriteLine($"{k} -> нет");
    }
}
