// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }

    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }

    Console.Write("]");
}

int size = 8;
int[] resultArray = CreateArray(size);
PrintArray(resultArray);
