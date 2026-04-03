using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 7, 2, 9, 5, 1 };

        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine("Sum = " + sum);
    }
}
