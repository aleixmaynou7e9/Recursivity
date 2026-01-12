using System;

class Program
{
    public static void Main()
    {
        Countdown(7);
    }
    public static void Countdown(int n)
    {
        if (n < 0) return;

        Console.WriteLine(n);
        Countdown(n - 1);
    }
}