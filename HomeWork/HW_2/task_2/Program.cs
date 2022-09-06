// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Input a number");
int number = Convert.ToInt32(Console.ReadLine());
string aux = Math.Abs(number).ToString();
if (aux.Length >= 3)
{
    Console.WriteLine($"The third digit of number {number} is {aux[2]}");
}
else
{
    Console.WriteLine($"The third digit of number {number} does not exist");
}