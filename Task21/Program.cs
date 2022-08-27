/*
Напишите программу, которая
принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("Введите три координаты точки A:");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите три координаты точки B:");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());
// Вычисление расстояния от точки А до точки В
double div1 = Math.Pow((x1 - x2), 2);
double div2 = Math.Pow((y1 - y2), 2);
double div3 = Math.Pow((z1 - z2), 2);
double distance = Math.Sqrt(div1 + div2 + div3);
// Округление значения до двух знаков после запятой
double r = Math.Round(distance, 2);
Console.WriteLine($"A({x1}, {y1}, {z1}); B({x2}, {y2}, {z2}) -> {r}");