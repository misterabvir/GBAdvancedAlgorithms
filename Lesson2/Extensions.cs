using Lesson2.Sorters.Base;

namespace Lesson2;

public static class Extensions
{
    public static int[] CreateRandomRange(this int length, int min = 10, int max = 100)
        => Enumerable.Range(0, length).Select(item => Random.Shared.Next(min, max)).ToArray();

    public static void Print(this int[] array, int limit = int.MaxValue, string? message = null)
        => Console.WriteLine($"{message?.GetFormat()}[{string.Join(", ", array.Take(limit))}]");

    private static string GetFormat(this string message) => (message + ": ").PadRight(15);

    public static void Swap(this int[] array, int index1, int index2)
        => (array[index1], array[index2]) = (array[index2], array[index1]);

    public static void PrintTitle(this string message)
    {
        ConsoleColor def = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = def;
        
    }
}
