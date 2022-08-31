/* Задача №4
Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел */
Console.Write("Ввод первого числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввод второго числа: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввод третьего числа: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.WriteLine($"Максимальное число: {max}");