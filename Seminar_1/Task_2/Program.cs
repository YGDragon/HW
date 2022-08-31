/* Задача №4
Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел */
Console.Write("Ввод первого числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввод второго числа: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввод третьего числа: ");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int max = number1;
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.WriteLine($"Максимальное число: {max}");