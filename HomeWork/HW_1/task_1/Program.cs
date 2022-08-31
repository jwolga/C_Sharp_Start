/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Input the first number");
var number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number");
var number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Number {number1} is the biggest and number {number2} is the smallest");
}
else 
{
    Console.WriteLine($"Number {number2} is the biggest and number {number1} is the smallest");
}

