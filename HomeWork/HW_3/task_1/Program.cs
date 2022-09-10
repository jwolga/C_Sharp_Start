/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

Console.WriteLine("Input 5 digits number");
string number =  Console.ReadLine();
if (number.Length != 5) 
{
    Console.WriteLine("Invalid number. Number should have 5 digits!");
    return;
}
if (number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine($"The number {number} is palindrome");
}
else
{
    Console.WriteLine($"The number {number} is not palindrome");
}