/* Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых на плоскости,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
  значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


Console.Write("Введите значение коэффициента k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение коэффициента b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение коэффициента k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение коэффициента b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
if(k1 == k2 && b1 != b2)
{
    Console.WriteLine("Прямые параллельны друг другу и не пересекаются");
}
else
{
    if(k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают и имеют бесконечное количество решений");
    }
    else
    {
        double x = -(b1 - b2) / (k1 - k2);
        double y = k1 * x + b1;
 
        x = Math.Round(x, 2);
        y = Math.Round(y, 2);
 
        Console.WriteLine($"Пересечение в точке: ({x};{y})"); 
    }
}