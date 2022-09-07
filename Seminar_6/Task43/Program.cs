/*
Задача 43:
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
// Комбинированный метод - вывод результата.
void OutResult()
{
    double[,] coef = new double[2, 2];
    GetCoefficient(coef);
    PrintArray(coef);
    LineCrossing(coef);
}

// Метод - определение коэффициентов для прямых.
void GetCoefficient(double[,] data)
{
    Console.WriteLine("Задание коэффициентов для прямой y = k1 * x + b1 :");
    Console.Write("Коэффициент b1 = ");
    data[0, 0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Коэффициент k1 = ");
    data[0, 1] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Задание коэффициентов для прямой y = k2 * x + b2");
    Console.Write("Коэффициент b2 = ");
    data[1, 0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Коэффициент k2 = ");
    data[1, 1] = Convert.ToDouble(Console.ReadLine());
}

// Метод - нахождение координат точки пересечения двух линий.
void LineCrossing(double[,] data)
{
    double x = (data[1, 0] - data[0, 0]) / (data[0, 1] - data[1, 1]);
    double y = data[1, 1] * x + data[1, 0];
    x = Math.Round(x, 1);
    y = Math.Round(y, 1);
    Console.Write($" -> ({x}; {y})");
}

// Метод - печать коэффициентов для вывода результата.
void PrintArray(double[,] data)
{
    Console.Write($"b1 = {data[0, 0]}, ");
    Console.Write($"k1 = {data[0, 1]}, ");
    Console.Write($"b2 = {data[1, 0]}, ");
    Console.Write($"k2 = {data[1, 1]} ");
}

// Вызов комбинированного метода.
OutResult();