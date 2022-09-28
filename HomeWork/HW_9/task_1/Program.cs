/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumElements(int m, int n)
{
    if (m == n) return m;
    return m + SumElements(m + 1, n);
}

Console.WriteLine("Input number M");
int m = Convert.ToInt32(Console.ReadLine());
if (m <= 0)
{
    Console.WriteLine("Number should be natural");
    return;
}
Console.WriteLine("Input number N");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 0)
{
    Console.WriteLine("Number should be natural");
    return;
}
Console.WriteLine($"Sum of numbers between {m} and {n} is {SumElements(m,n)}");