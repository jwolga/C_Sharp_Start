/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int number = new Random ().Next(100, 1000);
int num_1 = number / 10;
int num_2 = num_1 % 10;
Console.WriteLine($"The second digital of number {number} is {num_2}");*/


/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Input a number");
string number = Console.ReadLine();
char charDigital = number[2];

if (number[2] >= number [number.Length]) Console.WriteLine($"The third digital of number {number} is {number[3]}");
else Console.WriteLine($"The third digital of number {number} does not exist");*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.