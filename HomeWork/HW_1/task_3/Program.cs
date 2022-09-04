/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */ 

Console.WriteLine("Input a number");
var number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"The number {number} is even");
}
else 
{
    Console.WriteLine($"The number {number} is odd");
}
