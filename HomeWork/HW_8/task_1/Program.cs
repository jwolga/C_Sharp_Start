/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

//заполнить и напечатать исходный двумерный массив
//построчно смотреть и по убыванию от max до min(метод замены )
/*void selectionSort(int[] array)
{
for (int i = 0; i < array.Length - 1; i++)
{
int minPosition = i;
for (int j = i+1; j < array.Length; j++)
{
if(array[j] < array[minPosition]) minPosition = j;


int temporary = array[i]
array[i] = array[minPosition];
array[minPosition] = temporary;
}*/

// Заполнение двумерногомассива
int[,] CreateMatrix(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(-10, 11);
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

//Сортировка элементов по убыванию в строке
void SortRows(int[,] matrix, int row)
{
    for (int i = 0; i < matrix.GetLength(1) - 1; i++) // i - индекс текущего элемента одной row-й строки, временно считающегося max
    {
        int maxIdx = i;
        for (int j = i + 1; j < matrix.GetLength(1); j++) // j - индекс для перебора оставшихся элементов
            if (matrix[row, j] > matrix[row, maxIdx]) maxIdx = j;  // row - так как в одной и той же строке двумерного массива

        int tmp = matrix[row, i];
        matrix[row, i] = matrix[row, maxIdx];
        matrix[row, maxIdx] = tmp;
    }
}


//Сортировка элементов по столбцам в двумерном массиве
void SortMatrixColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        SortRows(matrix, i);
    }
}

// Программа
Console.WriteLine("Input number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = CreateMatrix(rows, columns);
Console.WriteLine($"Source matrix:");
PrintMatrix(resultMatrix);
SortMatrixColumns(resultMatrix);
Console.WriteLine($"Sorted matrix:");
PrintMatrix(resultMatrix);
