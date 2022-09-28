/*факториал

int Factorial(int n)
{
    // Базовый случай - случай выхода из рекурсии, рекурсия становится конечной, есть условие выхода
    if(n == 1) return 1;
    // Рекурсивный случай, вызов функции саму через себя до самого значения
    return (n * Factorial(n-1));
}
Console.WriteLine(Factorial(4));*/
/*Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
int n = Convert.ToInt32(Console.ReadLine());
// start - первое число по условию end - конец, последнее
 string PrintNumbers(int start, int end)
 { //Базовый случай
    if(start == end) return start.ToString();
    // Рекурсивный случай
    return(start + ", " + PrintNumbers(start + 1, end));
     }
     Console.WriteLine(PrintNumbers(1, n));
     int m = Convert.ToInt32(Console.ReadLine());
     int n = Convert.ToInt32(Console.ReadLine());
     if(m > n)
     {
        Console.WriteLine("Failed");
        return;
     }
// start - первое число по условию end - конец, последнее
 string PrintNumbers(int start, int end)
 { //Базовый случай
    if(start == end) return start.ToString();
    // Рекурсивный случай
    return(start + ", " + PrintNumbers(start + 1, end));
     }
     Console.WriteLine(PrintNumbers(m, n));*/

     /*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9

//45 % 10 = 5 (остаток)
//45 / 10 = 4 (целых)

int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    if(num == 0) return 0; 

    return(num % 10 + SumNumbers(num / 10));
}
Console.WriteLine(SumNumbers(number));*/

/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/
Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input digree");
int degree = Convert.ToInt32(Console.ReadLine());

int Power(int number, int power)
{
    if(power == 0) return 1;
    if(power == 1) return number;

    return(number * Power(number, power - 1));
}
Console.WriteLine(Power(number, degree));