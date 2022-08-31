/*
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string cell = "1";
// Вычисление результата последовательно для двух чисел
for (int n = 1; n < 3; n++)
{
    // Формирование таблицы кубов чисел
    for (int i = 2; i < num + 1; i++)
    {
        cell = cell + ',' + " " + Math.Pow(i, 3);
    }
    Console.WriteLine($"{num} " + "->" + " " + cell); // Вывод результата
    // Условие прерывания ввода следующего числа
    if (n == 2)
    {
        break;
    }
    Console.Write("Введите слудующее число: ");
    num = Convert.ToInt32(Console.ReadLine());
}