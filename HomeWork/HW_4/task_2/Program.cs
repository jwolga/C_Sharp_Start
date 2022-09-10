//27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Count(int num)
{
    int count = 0;
    while (Math.Abs(num) > 0)
    {
        count++;
        num = num / 10;
    }

    return count;
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }

    return sum;
}

Console.WriteLine("Input number");

int num = Convert.ToInt32(Console.ReadLine());
int count = Count(num);

int[] arrayNumber = new int[count];

for (int i = 0; i < arrayNumber.Length; i++)
{
    arrayNumber[i] = Math.Abs(num) % 10;
    num = num / 10;
}
 int sum = Sum(arrayNumber);

 Console.WriteLine($"Sum of digits is {sum}");




