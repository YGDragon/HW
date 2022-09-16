/*
Задача 62.
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
*/
string [,] spiral = new string[5,4];
int size = spiral.Length;
string[] numbers = new string[size];
int row = spiral.GetLength(0);
int column = spiral.GetLength(1);

FillArrayNum(numbers);
PrintSingleArray(numbers);
FillHighRow(spiral, numbers, column);
PrintArray(spiral);
// Метод - заполнение одномерного строкового массива числами.
void FillArrayNum(string[] oneRow)
{
  for (int i = 0; i < oneRow.Length; i++)
  { 
    oneRow[i] = i <= 8 ? (0 + $"{i + 1}") : $"{i + 1}";
    if (i == 9)
    {
      oneRow[i] = "10";
    }
  }
}
  
void FillHighRow(string[,] data, string[] filler, int c)
{
    for (int j = 0; j < c; j++)
    {
    data[0,j] = filler[j];
    }
}

/*for (int i = 0; j < column; j++)
{
  for (int i = 0; i < row; i++)
  {
    spiral[i,j] = 
  }
}*/
void PrintArray(string[,] data)
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            Console.Write($"{data[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Метод - вывод на печать одномерного массива.
void PrintSingleArray(string[] data)
{
    for (int i = 0; i < data.Length; i++)
    {
        Console.Write($"{data[i]}\t");
    }
    Console.WriteLine();
}
