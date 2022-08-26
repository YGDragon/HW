/*
Напишите программу, которая
принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num <= 10000 || num >= 100000) // Проверка на правильность ввода числа
{
    Console.Write("Введено неверное значение. ");
    Console.Write("Введите пятизначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}
int[] array = new int[5]; // Определение цифр в заданном числе
for (int i = 4; i >= 0; i--)
{
    int part = Math.DivRem(num, 10, out int d);
    num = part;
    array[i] = d;
}
int dir = array[0] + array[1] + array[2]; // Определение числа как полиндрома
int rev = array[2] + array[3] + array[4];
if (dir == rev)
{
    Console.Write($"Число является полиндромом");
}
else
{
    Console.Write($"Число не является полиндромом");
}