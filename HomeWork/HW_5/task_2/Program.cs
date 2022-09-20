/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/
int size = 7;
int [] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1,10);
    Console.Write(array[i] + "\t");
}
int sum = 0;
for (int i = 0; i < size; i++)
{
    if (i % 2 != 0)
    {
        sum += array[i];
    }
}
Console.WriteLine();
Console.Write($"Sum of elements in odd positions: {sum}");

