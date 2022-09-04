/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Input the first number");
var number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number");
var number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Input the third number");
var number3 = int.Parse(Console.ReadLine());
var max = number1;

if(number2 > max)
{
    max = number2;
}
if(number3 > max)
{
    max = number3;
}

Console.WriteLine($"The max number is {max}");