/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

double[,] GetMatrixRnd(int m, int n)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
        }
    }
    return result;
}

void PrintMatrix(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input the number of rows");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the number of columns");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] resultMatrix = GetMatrixRnd(rows, columns);
PrintMatrix(resultMatrix);