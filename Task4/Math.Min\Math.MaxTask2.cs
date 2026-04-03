using System;

class Program
{
    static void Main()
    {
        int[] temps = { 12, -3, 45, 0, 28, -10, 33 };
        int min = temps[0];
        int max = temps[0];
        foreach (int temp in temps)
        {
            min = Math.Min(min, temp);
            max = Math.Max(max, temp);
        }
        Console.WriteLine("Min = " + min + ", Max = " + max);
    }
}
