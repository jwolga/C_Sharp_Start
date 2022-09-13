/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20

int size = 12;

int[] array = new int[size];
int resultPositive = 0;
int resultNegative = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.Write(array[i] + "\t");

    if (array[i] > 0)
    {
        resultPositive += array[i];
    }
    else
    {
        resultNegative += array[i];
    }
}
Console.WriteLine($"\nSum positive: {resultPositive}\nSum negative: {resultNegative}");*/

//---------------------------------------------------------------------------------------------------------------------------------------------


/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

int size = 12;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1, 120);
    Console.Write(array[i] + "\t");
}

int count = 0;
for (int i = 0; i < size; i++)
{
    if (array[i] >= 10 && array[i] <= 99)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Count {count}");*/

/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
int size = 10;
int [] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-7,7);
    Console.Write(array[i] + "\t");
}
Console.WriteLine();
for (int i = 0; i < size; i++)
{
    array[i] = -array[i];     // array[i] *= (-1)
    Console.Write(array[i] + "\t");
}*/

/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
int[] array = { -2, -1, 0, 1, 2 };
int searchNumber = 3; // Число за рамкаками нашего массива
bool flagResult = false; // false - элемент не найден, true - найден
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == searchNumber)
    {
        flagResult = true; // Элемент найден
        break;
    }
}
// (flagResult == true) == if(flagResult)
if (flagResult) Console.WriteLine($"Элемент {searchNumber} присутствует");
else Console.WriteLine($"Элемент {searchNumber} отстутствует");*/
//***********************************************************************************************
/*она же
int size = 12;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + "\t");
}
Console.WriteLine();
Console.WriteLine("Input search key (a number from 1 to 10)");
int key = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < size; i++)
{
    if (array[i] == key)
    {
        Console.WriteLine($"The key has been found at position {i}");
        return;
    }
}

Console.WriteLine("The key has not been found");*/

