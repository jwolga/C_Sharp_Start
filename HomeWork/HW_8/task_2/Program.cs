/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


int[,] CreateMatrix(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 11);
        }
    }
    return result;
}
//Печать двумерного массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int CalcSumRow(int[,] matrix, int rowIdx)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        sum += matrix[rowIdx, j];
    return sum;
}

Console.WriteLine("Input number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns");
int columns = Convert.ToInt32(Console.ReadLine());
if (rows == columns)
{
    Console.WriteLine("The matrix shoud not be square");
    return;
}

int[,] resultMatrix = CreateMatrix(rows, columns);
PrintMatrix(resultMatrix);

int minSum = int.MaxValue;
int minSumIdx = 0;
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    int resultSum = CalcSumRow(resultMatrix, i);
    if (resultSum < minSum)
    {
        minSum = resultSum;
        minSumIdx = i;
    }
}
Console.WriteLine($"The index of the row with minimal sum of elements is {minSumIdx + 1}");
