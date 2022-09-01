/*
Задача 29: Напишите программу, которая
задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
// Определение функции задания и вывода массива
void NumberArray(int[] num)
{
    string line = String.Empty;
    int l = num.Length - 1;
    for (int i = 0; i < l; i++)
    {
        num[i] = new Random().Next(1, 40);
        line = line + $"{num[i]}, ";
    }
    num[l] = new Random().Next(1, 40);
    line = line + $"{num[l]}";
    Console.Write(line + " -> [" + line + "]");
}
int[] inputnum = new int[8];
// Вызов функции
NumberArray(inputnum);
