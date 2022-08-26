/*
Напишите программу, которая
принимает на вход число (N) и
выдаёт таблицу кубов чисел от 1 до N.
*/
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string message = "1";
for (int i = 2; i <= num; i++)
{
    message = message + ',' + " " + i * i * i;
}
Console.WriteLine(message);