/*
Задача 13:
Напишите программу, которая выводит
третью цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 && number > -100) //Условие проверки числа на наличие третьей цифры
{
    Console.WriteLine();
    Console.WriteLine($"В числе отсутствует третья цифра");
}
else
{
    int digit = 0;
    do
    {
        number = Math.DivRem(number, 10, out digit); //  Нахождение третьей цифры слева
    }
    while (number >= 100 || number <= -100);
    int digit3 = Math.Abs(digit);
    Console.WriteLine($"Третья цифра числа равна {digit3}");
}
