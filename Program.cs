using System;

class Program
{
    public static void Main()
    {
        int valorTotal;
        
        valorTotal=AddDigits(123);
        Console.WriteLine(valorTotal);
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
    public static int AddDigits(int n)
    {
        int ultimDigit = n % 10, valorTotal = 0;
        if (n < 10) return n;
         
        
        valorTotal = AddDigits(n/10);
        ultimDigit = n % 10;
        valorTotal += ultimDigit;
        return valorTotal;
    }
}