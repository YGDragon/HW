/* Задача №8
Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N. */
Console.Write("Ввод числа: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 2;
Console.WriteLine("Все четные числа:");
while (index < number)
{
    Console.Write($"{index} \t");
    index+=2;
}