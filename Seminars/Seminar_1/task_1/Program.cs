//На вход 2 числа, является ли первое квадратом второго

Console.WriteLine("Input the first number");
var number_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number");
var number_2 = int.Parse(Console.ReadLine());

if (number_1 == number_2 * number_2)
{
    Console.WriteLine($"Number {number_1} is {number_2} ^2");
}
else
{
    Console.WriteLine($"Number {number_1} is not {number_2} ^2");
}