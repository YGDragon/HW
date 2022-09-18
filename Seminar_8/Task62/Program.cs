/*
Задача 62.
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

//Комбинированный метод - вывод результата.
void OutResult()
{   // исходный двумерный массив
    string[,] spiral = new string[4, 4];
    TwoFill(spiral);
    Console.WriteLine("Исходный двумерный массив:");
    PrintTwoArray(spiral);
    // исходный зубчатый массив
    string[][] numbers = {
    new string[3],
    new string[3],
    new string[3],
    new string[3],
    new string[2],
    new string[1],
    new string[1]};
    // заполнение и вывод зубчатого массива
    JaggedFill(numbers);
    Console.WriteLine("Зубчатый массив чисел:");
    PrintJagArray(numbers);
    //Console.WriteLine();
    // заполнение и вывод зубчатого массива
    SpiralFill(spiral, numbers);
    Console.WriteLine("Заполненный двумерный массив:");
    PrintTwoArray(spiral);
}

// Метод №1 - заполнение двумерного массива.
void TwoFill(string[,] dataTwo)
{
    for (int i = 0; i < dataTwo.GetLength(0); i++)
    {
        for (int j = 0; j < dataTwo.GetLength(1); j++)
        {
            dataTwo[i, j] = "00";
        }
    }
}

// Метод №2 - заполнение зубчатого массива.
void JaggedFill(string[][] dataJag)
{
    int coef = 1;
    for (int i = 0; i < dataJag.GetLength(0); i++)
    {
        for (int j = 0; j < dataJag[i].Length; j++)
        {
            string line1 = "0" + Convert.ToString(coef);
            string line2 = Convert.ToString(coef);
            dataJag[i][j] = coef < 10 ? line1 : line2;
            coef++;
        }
    }
}

// Метод №3 - вывод на печать двумерного массива.
void PrintTwoArray(string[,] dataT)
{
    for (int i = 0; i < dataT.GetLength(0); i++)
    {
        for (int j = 0; j < dataT.GetLength(1); j++)
        {
            Console.Write($"{dataT[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Метод №4 - вывод на печать зубчатого массива.
void PrintJagArray(string[][] dataJ)
{
    for (int i = 0; i < dataJ.GetLength(0); i++)
    {
        for (int j = 0; j < dataJ[i].Length; j++)
        {
            Console.Write($"{dataJ[i][j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Метод №5 - спиральное заполнение двумерного массива.
void SpiralFill(string[,] arrayTwo, string[][] arrayJag)
{
    int g = 0; // индекс зубчатого массива
    int n = 0; // счетчик заполнения 
    for (n = 0; n < 2; n++)
    {
        RigthFill(arrayTwo, arrayJag, n, g);
        g = g == 4 ? 1 : g + 4;
    }
    for (n = 0; n < 2; n++)
    {
        DownFill(arrayTwo, arrayJag, n, g);
        g = g == 5 ? 2 : g + 4;
    }
    for (n = 0; n < 2; n++)
    {
        LeftFill(arrayTwo, arrayJag, n, g);
        g = g == 6 ? 3 : g + 4;
    }
    UpFill(arrayTwo, arrayJag, g);
}

// Метод №6 - заполнение массива вправо.
void RigthFill(string[,] arrayTwo, string[][] arrayJag, int n, int g)
{
    for (int j = 0; j < arrayJag[g].Length; j++)
    {
        arrayTwo[n, j + n] = arrayJag[g][j];
    }
}

// Метод №7 - заполнение массива вниз.
void DownFill(string[,] arrayTwo, string[][] arrayJag, int n, int g)
{
    for (int i = 0; i < arrayJag[g].Length; i++)
    {
        arrayTwo[i + 2 * n, 3 - n] = arrayJag[g][i];
    }
}

// Метод №8 - заполнение массива влево.
void LeftFill(string[,] arrayTwo, string[][] arrayJag, int n, int g)
{
    for (int j = 0; j < arrayJag[g].Length; j++)
    {
        arrayTwo[3 - n, arrayJag[g].Length - j] = arrayJag[g][j];
    }
}

// Метод №9 - заполнение массива вверх.
void UpFill(string[,] arrayTwo, string[][] arrayJag, int g)
{
    for (int i = 0; i < arrayJag[g].Length; i++)
    {
        arrayTwo[arrayJag[g].Length - i, 0] = arrayJag[g][i];
    }
}

OutResult();