// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Input a digit");
int digit = Convert.ToInt32(Console.ReadLine());
if (digit < 1 || digit > 7)
{
    Console.WriteLine($"{digit} is invalid week day number");
}
else
{
    if (digit == 6 || digit == 7)
    {
        Console.WriteLine("This day is a weekend");
    }
    else
    {
        Console.WriteLine("This day is a week day ");
    }
}