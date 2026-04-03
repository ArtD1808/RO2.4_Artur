using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;

        int[] rotated = RotateLeft(arr, k);
        Console.WriteLine(string.Join(" ", rotated));
    }

    static int[] RotateLeft(int[] arr, int k)
    {
        int n = arr.Length;
        int[] result = new int[n];
        for (int i = 0; i < n; i++)
        {
            result[i] = arr[(i + k) % n];
        }
        return result;
    }
}
