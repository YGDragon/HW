/*
Задача 64: Задайте значения M и N.
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
int numberM = 10;
int numberN = 15;
string lineNum = LineElements(numberM, numberN);
Console.Write($"M = {numberM}; N = {numberN}. -> " + $"\"\"{lineNum}\"\"");

string LineElements(int n1, int n2)
{
    if (n1 == n2)
    {
        return Convert.ToString(n1);
    }
    return ($"{n1}" + ", " + LineElements(n1 + 1, n2));
}