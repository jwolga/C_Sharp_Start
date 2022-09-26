/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] CreateCube(int m, int n, int l)
{
    int[,,] result = new int[m, n, l];
    // fill - заполнитель, 10 - минимальное двузначное число
    int fill = 10;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                result[i, j, k] = fill++;
            }
        }
    }
    return result;
}

void PrintCube(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                Console.Write($"{cube[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}


Console.WriteLine("Input length");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input width");
int width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input depth");
int depth = Convert.ToInt32(Console.ReadLine());
if(length * width * depth > 100)
{
    Console.WriteLine("Number of cub's elements shoud be less than 100");
    return;
}
 int[,,] resultCube = CreateCube(length, width,depth);
 PrintCube(resultCube);