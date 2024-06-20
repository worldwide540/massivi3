using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 10, 15, 20, 25 };

        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }

        double average = (double)sum / array.Length;

        Console.WriteLine($"Сумма элементов массива: {sum}");
        Console.WriteLine($"Среднее арифметическое значение элементов массива: {average}");
    }
}
