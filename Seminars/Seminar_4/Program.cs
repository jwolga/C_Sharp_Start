/*Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= A; i++)

{
    sum = sum + i;
}
Console.WriteLine($"Sum of number since 1 until {A} = {sum}");*/

/*МЕТОД
Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int end)
{
  int sum = 0;
for (int i = 1; i <= end; i++)

{
    sum = sum + i;
}
 return sum;
}


Console.WriteLine(SumNumbers(number));

Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

/*Console.Write("Input number");
int number = Convert.ToInt32(Console.ReadLine());

int GetCountNumbers (int num)
{
    int count = 0;
    while (num > 0 )
    {
        count++;
        num = num / 10;
    }
}

Console.Write("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine()); // Глобальная , то есть, доступна везде
Console.WriteLine(GetMultiply(N));
Console.WriteLine(GetMultiply(5));
Console.WriteLine(GetMultiply(6));
Console.WriteLine(GetMultiply(7));
Console.WriteLine(GetMultiply(8));

// PascalCase - обе буквы заглавные: PrintNumbers
int GetMultiply (int N) // Вторая переменная, она локальная
// Она живет только внутри метода, только внутри {}
{
    int result = 1; // Число * 0 = 0
    for (int i = 2; i <= N; i++)
    {
        result *= i; // result = result * i
    }
    return result; 
}*/

/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
int[] GetBinaryArray(int size)
{
    int[] array = new int[size]; // size = 5, array = [0,0,0,0,0]
    for (int i = 0; i < array.Length; i++) // array.Length = size
    {
        array[i] = new Random().Next(2); // Next(5) => от 0 до 4
    }
    return array;
}
int[] resultArray = GetBinaryArray(8);

// Конвертируем массив в строчку

Console.WriteLine($"Result array: [ {String.Join("; ", resultArray)} ]");*/
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//ДЗ
/* 25  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Input number A");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number B");
int B = Convert.ToInt32(Console.ReadLine());
double result = 0;
 for (int i = 0; i <= B; i++)
 {
    result = Math.Pow(A, i);
 }
Console.WriteLine($"Result {result}");*/

/* 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Input number");

int num= Convert.ToInt32(Console.ReadLine());
int count = 0;
    while (num > 0 )
    {
        count++;
        num = num / 10;
    }


int [] arrayNumber = new int [count];

for (int i = 0; i <= arrayNumber.Length; i++)
{
    arrayNumber [i] = 
}


int sum = 0;

for (int i = 0; i <= count; i++)
{
 int result = sum + arrayNumber[i];
}
Console.WriteLine($"Sum digits is {sum}");*/






















































