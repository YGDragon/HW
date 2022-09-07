/*
Задача 41:
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
// Комбинированный метод - вывод результата.
void OutResult()
{
    Console.Write($"Задать количесто чисел для ввода: ");
    int inputAll = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[inputAll];
    FillArray(numbers);
    PrintArray(numbers);
    PositiveNums(numbers);
}

// Метод - заполнение массива введенными числами.
void FillArray(int[] data)
{
    for (int i = 0; i < data.Length; i++)
    {
        data[i] = Convert.ToInt32(Console.ReadLine());
    }
}

// Метод - определение количества чисел больше 0.
void PositiveNums(int[] data)
{
    int sum = 0;
    foreach (int k in data)
    {
        sum += k > 0 ? 1 : 0;
    }
    Console.Write(sum);
}

// Метод - печать коэффициентов для вывода результата.
void PrintArray(int[] data)
{
    string line = String.Empty;
    int l = data.Length - 1;
    double last = data[l];
    for (int i = 0; i < l; i++)
    {
        line += $"{data[i]}, ";
    }
    Console.Write(line + $"{last} -> ");
}

// Вызов комбинированного метода.
OutResult();