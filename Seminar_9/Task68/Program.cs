/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/
int number1 = 3;
int number2 = 2;
int num = AkkermanF(number1, number2);
Console.Write($"m = {number1}; n = {number2}. -> A(m,n) = " + num);

int AkkermanF(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if ((m != 0) && (n == 0))
    {
        return AkkermanF(m - 1, 1);
    }
    return AkkermanF(m - 1, AkkermanF(m, n - 1));
}
