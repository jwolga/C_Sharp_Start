/*functions

1.
int Calculate (int a, int b)
{
    int result = a + b;
    return result;
}
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your result {Calculate(num1,num2)}");*/

/* 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Input digit of X");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Input digit of Y");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0) Console.WriteLine("I quarter");
else if (X < 0 && Y > 0) Console.WriteLine("II quarter");
else if (X < 0 && Y < 0) Console.WriteLine("III quarter");
else  Console.WriteLine("IV quarter");*/

/* Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

Console.WriteLine("Input number quarter");
int quarter = Convert.ToInt32(Console.ReadLine());


if (quarter == 1) Console.WriteLine("x > 0 and y > 0");
else if (quarter == 2)  Console.WriteLine("x < 0 and y > 0");
else if (quarter == 3) Console.WriteLine("x < 0 and y < 0");
else if (quarter == 4) Console.WriteLine("x > 0 and y < 0");

else  Console.WriteLine("quarter not found");*/

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Input x1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input x2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input y2");
int y2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x2 - x1, 2 ) + Math.Pow(y2 - y1, 2));

Console.WriteLine($"Distanse {Math.Round(d,3)}");*/

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4

Console.WriteLine("Input digit");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i * i);
}*/


