/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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

// Подсчет суммы произведений, считает элемент матрицы произведений
int CalcMultipliedElement(int[,] a, int[,] b, int i, int j)
{
    int sumMult = 0;
    //k - индекс строки/столбца в матрице произведения
    for (int k = 0; k < a.GetLength(1); k++)
        sumMult += a[i, k] * b[k, j];
    return sumMult;
}

int[,] MultiplyMatrix(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0) || a.GetLength(0) != b.GetLength(1))
    {
        Console.WriteLine("The sizes of rows and columns should correspond");
        return new int[0, 0];
    }
    int[,] result = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = CalcMultipliedElement(a, b, i, j);
        }
    }
    return result;
}

Console.WriteLine("Input number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Matrix A:");
int[,] matrixA = CreateMatrix(rows, columns);
PrintMatrix(matrixA);
Console.WriteLine("Matrix B:");
int[,] matrixB = CreateMatrix(columns, rows);
PrintMatrix(matrixB);
int[,] resultMatrix = MultiplyMatrix(matrixA, matrixB);
Console.WriteLine("Multiplication of two matrixes:");
PrintMatrix(resultMatrix);