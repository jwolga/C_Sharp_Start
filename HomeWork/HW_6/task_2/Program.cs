/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
double[] PointIntersection(double k1, double b1, double k2, double b2)
{

    double[] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1 * result[0] + b1;
    return result;
}
Console.WriteLine("Input k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b2");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The first equation y = {k1}*x + {b1}");
Console.WriteLine($"The second equation:  y = {k2}*x + {b2}");

double[] array = PointIntersection(k1, b1, k2, b2);
Console.WriteLine($"Point of intersection of lines: ({Math.Round(array[0], 2)} ; {Math.Round(array[1], 2)})");








