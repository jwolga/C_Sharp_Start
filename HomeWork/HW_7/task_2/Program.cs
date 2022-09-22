/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/

int[,] GetMatrixRnd(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input the number of rows");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the number of columns");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = GetMatrixRnd(rows, columns);
PrintMatrix(resultMatrix);

Console.WriteLine("Input the the positions of element");
Console.WriteLine("Input the row");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the column");
int column = Convert.ToInt32(Console.ReadLine());



if (row >=0 && row < resultMatrix.GetLength(0) && column >= 0 && column < resultMatrix.GetLength(1))
{
    Console.Write(resultMatrix[row, column]);
}
else
{
    Console.Write($"Element of matrix[{row},{column}] not found");
}

