/* Задача №2
Напишите программу, которая на вход принимает два числа
и выдаёт, какое число больше, а какое меньше.
*/
Console.Write("Ввод первого числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввод второго числа: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine($"Большее число: {number1}");
    Console.WriteLine($"Меньшее число: {number2}");
}
else
{
    Console.WriteLine($"Большее число: {number2}");
    Console.WriteLine($"Меньшее число: {number1}");
}