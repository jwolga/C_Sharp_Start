/*/// Написать программу, которая из имеющегося 
/// массива целых чисел должна сформировать
/// новый массив содержащий только четные числа*/

int[] GetRndArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
        result[i] = new Random().Next(1, 100);
    return result;
}

int[] GetOnlyEven(int[] array)
{
    int countEven = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            countEven++;

    int[] result = new int[countEven];

    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result[j] = array[i];
            j++;
        }
    }

    return result;
}

Console.WriteLine("Введите размера массива");
int s = Convert.ToInt32(Console.ReadLine());

int[] sourceArray = GetRndArray(s);

Console.Write($"Исходный массив: {string.Join('\t', sourceArray)}\n");

int[] resultArray = GetOnlyEven(sourceArray);

Console.WriteLine($"Массив только четных элементов: {string.Join('\t', resultArray)}");