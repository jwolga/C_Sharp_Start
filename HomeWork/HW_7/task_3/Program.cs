/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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

double[] avg = new double[columns];

for (int j = 0; j < resultMatrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        sum += resultMatrix[i, j];
    }
    avg[j] = Math.Round(sum / resultMatrix.GetLength(0), 2);
}
Console.WriteLine($"Averages of colums are: {String.Join('\t', avg)}");