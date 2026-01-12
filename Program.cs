using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine(Swap(210));
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
    public static int Swap(int n)
    {
        return SwapAux(n, 0);
    }


    private static int SwapAux(int n, int result)
    {
        if (n == 0) return result;

        result = result * 10 + (n % 10);

        return SwapAux(n/10, result);
    }

}