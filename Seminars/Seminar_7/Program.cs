/*Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1*/


//Заполнение массива

int[,] GetMatrixRnd(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(11);
        }

    }
    return result;
}

// Печать массива

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

/*Console.WriteLine("Input the number of rows");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the number of columns");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = GetMatrix(rows, columns);
PrintMatrix(resultMatrix);*/



/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/

int[,] GetMatrixSum(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }

    }
    return result;
}

/*Console.WriteLine("Input the number of rows");
int m = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input the number of columns");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = GetMatrixSum(m,n);
PrintMatrix(resultMatrix);*/



/*49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] *= matrix[i, j];
            }
        }
    }
}*/

/*void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

Console.WriteLine("Input the number of rows");
int m = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input the number of columns");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = GetMatrixRnd(m, n);
Console.WriteLine("Initial matrix:");
PrintMatrix(resultMatrix);
ChangeMatrix(resultMatrix);
Console.WriteLine("Changed matrix:");
PrintMatrix(resultMatrix);*/





/*51. Найти сумму элементов главной диагонали*/

int CalcSumDiagonal(int[,] matrix)
{
    int sum = 0;
    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
        Console.WriteLine("Matrix should be square");
        return int.MinValue;
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum += matrix[i, j];
        }
    }
    return sum;
}

Console.WriteLine("Input the number of rows");
int m = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input the number of columns");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = GetMatrixRnd(m, n);
PrintMatrix(resultMatrix);
Console.WriteLine($"The sum of Main Diagonal elements is {CalcSumDiagonal(resultMatrix)}");
