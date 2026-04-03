using System;

class Program
{
    static void Main()
    {
        string[] words = { "apple", "banana", "cherry", "date" };
        string[] manual = (string[])words.Clone();
        for (int i = 0; i < manual.Length / 2; i++)
        {
            string temp = manual[i];
            manual[i] = manual[manual.Length - 1 - i];
            manual[manual.Length - 1 - i] = temp;
        }
        Console.WriteLine(string.Join(" ", manual));
    }
}
