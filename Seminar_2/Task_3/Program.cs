/*
Задача 15:
Напишите программу, которая принимает
на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
*/
Console.Write("Введите номер дня недели: ");
int weekday = Convert.ToInt32(Console.ReadLine()); //Введение номера дня недели
while (weekday < 1 || weekday > 7) //Проверка номера на правильность ввода
    {
        Console.WriteLine();
        Console.WriteLine("Не верно указан номер дня недели!");
        Console.Write("Введите номер дня недели: ");
        weekday = Convert.ToInt32(Console.ReadLine());
    }
if (weekday == 6 || weekday == 7)
{
    Console.WriteLine("День - выходной");
}
else
{
    Console.WriteLine("День - невыходной");
}