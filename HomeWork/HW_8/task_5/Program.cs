/** Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:


 1  2  3  4
12 13 14  5
11 16 15  6
10  9  8  7*/

bool IsEven(int value)
{
    return value % 2 == 0;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
//Заполняет верхнюю строку ВПЕРЁД
int FillRowForward(int[,] matrix, int colOffset, int rowOffset, int fillValue)
{
    for (int i = colOffset; i < matrix.GetLength(1) - colOffset; i++)
        matrix[rowOffset, i] = fillValue++;
    return fillValue;
}
//Заполняет нижнюю строку НАЗАД
int FillRowBackword(int[,] matrix, int colOffset, int rowOffset, int fillValue)
{
    for (int i = matrix.GetLength(1) - colOffset - 1; i >= colOffset; i--)
        matrix[matrix.GetLength(0) - rowOffset - 1, i] = fillValue++;
    return fillValue;
}
//Заполняет крайний столбец ВНИЗ
int FillColDown(int[,] matrix, int colOffset, int rowOffset, int fillValue)
{
    for (int j = rowOffset + 1; j < matrix.GetLength(0) - rowOffset - 1; j++)
        matrix[j, matrix.GetLength(1) - colOffset - 1] = fillValue++;
    return fillValue;
}
//Заполняет первый столбец ВВЕРХ
int FillColUp(int[,] matrix, int colOffset, int rowOffset, int fillValue)
{
    for (int j = matrix.GetLength(0) - rowOffset - 2; j > rowOffset; j--)
        matrix[j, colOffset] = fillValue++;
    return fillValue;
}

Console.WriteLine("Input number of rows");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number of columns");
int n = Convert.ToInt32(Console.ReadLine());

if (!IsEven(m))
{
    Console.WriteLine("The number of rows should be even");
    return;
}

if (!IsEven(n))
{
    Console.WriteLine("The number of columns should be even");
    return;
}

int[,] matrix = new int[m, n];
int colOffset = 0;
int rowOffset = 0;
int fillValue = 1;

while (rowOffset * 2  < m && colOffset * 2 < n)
{
    fillValue = FillRowForward(matrix, colOffset, rowOffset, fillValue);
    fillValue = FillColDown(matrix, colOffset, rowOffset, fillValue);
    fillValue = FillRowBackword(matrix, colOffset, rowOffset, fillValue);
    fillValue = FillColUp(matrix, colOffset, rowOffset, fillValue);
    rowOffset++;
    colOffset++;
}
PrintMatrix(matrix);