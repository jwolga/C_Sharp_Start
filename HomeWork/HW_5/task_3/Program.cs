/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

int size = 10;
double[] array = new double[size];
double max = double.MinValue;
double min = double.MaxValue;

for (int i = 0; i < size; i++)
{
    array[i] = Math.Round(new Random().NextDouble() * 10, 2);
    Console.Write(array[i] + "\t");

    if (array[i] > max) max = array[i];

    if (array[i] < min) min = array[i];
}

double result = max - min;
Console.WriteLine();
Console.Write($"Maximum array element: {max}\nMinimum array element: {min}\nDifference max and min {result}");
//--------------------------------------------------------------------------------------------------------------------------------------------------
/*int size = 10;
double[] array = new double[size];

for (int i = 0; i < size; i++)
{
    array[i] = Math.Round(new Random().NextDouble()*10, 2);
    Console.Write(array[i] + "\t");
}
double max = array[0];
double min = array[0];
for (int i = 0; i < size; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
double result = max - min;
Console.WriteLine();
Console.Write($"Maximum array element: {max}\nMinimum array element: {min}\nDifference max and min {result}");*/

