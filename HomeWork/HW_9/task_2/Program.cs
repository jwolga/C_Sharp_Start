/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
int A (int m, int n)
{
    if(m == 0) return n + 1;
    if(n == 0) return A(m - 1, 1);
    return A(m - 1, A(m, n - 1));
}

Console.WriteLine("Input number M");
int m = Convert.ToInt32(Console.ReadLine());
if (m < 0)
{
    Console.WriteLine("Number should be non-negative");
    return;
}
Console.WriteLine("Input number N");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
{
    Console.WriteLine("Number should be non-negative");
    return;
}
Console.WriteLine($"A({m},{n}) = {A(m,n)}");