/* Задача №6
Напишите программу, которая на вход принимает число
и выдаёт, является ли число чётным. */
Console.Write("Ввод целого числа: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (n % 2 == 0) Console.WriteLine($"Число {n} - четное");
else Console.WriteLine($"Число {n} - нечетное");