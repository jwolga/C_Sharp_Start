/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

int Pow(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }

    return result;
}

Console.WriteLine("Input number A");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number B");
int B = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Result is {Pow (A, B)}");


