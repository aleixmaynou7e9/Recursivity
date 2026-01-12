using System;

class Program
{
    public static void Main()
    {

        int count;
        
        count = CountDigits(233337);
        Console.WriteLine(count);
    }
    public static void Countdown(int n)
    {
        if (n < 0) return;

        Console.WriteLine(n);
        Countdown(n - 1);
    }
    public static int CountDigits(int n)
    {
        int count = 0;
        if (n < 10) return 1 ;
        
        count = CountDigits(n /= 10);
        count++;
        return count;
        
        
    }
    
}