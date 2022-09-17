/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/
int[] UserArray(int size)              // Метод заполнение массива с клавиатуры
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input the {i + 1} number");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


void PrintArray(int[] array)                       //Метод печать массива
{
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] + "\t");
    Console.WriteLine();
}


int CountNumber(int[] array)                 //Метод подсчета количества чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


Console.WriteLine("Input size of the array");
int userSize = Convert.ToInt32(Console.ReadLine());
int[] userArray = UserArray(userSize);
PrintArray(userArray);
Console.WriteLine($"The number of numbers bigger than zero: {CountNumber(userArray)}");




