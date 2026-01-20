using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine(MCD(48, 18));
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
        int ultimDigit, valorTotal = 0;
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
    public static void PrintForwardArray(int[] arrayInt, int index)
    {
        if (index > arrayInt.Length - 1) return;

        Console.Write($"{arrayInt[index]} ");

        PrintForwardArray(arrayInt, index + 1);
    }

    public static void PrintBackwardArray(int[] arrayInt, int index)
    {
        if (index < 0) return;
        
        Console.Write($"{arrayInt[index]} ");

        PrintBackwardArray(arrayInt, index - 1);
    }
    public static int FinddMax(int[] arrayInt, int index)
    {
        if (index == arrayInt.Length - 1)
        {
            return arrayInt[index];
        }

        int maxim = FinddMax(arrayInt, index+1);

        return Math.Max(arrayInt[index], maxim);

    }
    public static bool IsPalindrome(string word)
    {
        
        if (word.Length == 0  || word.Length == 1)
        {
            return true;
        }

        if (word[0] != word[word.Length-1]) 
        {
            return false;
        }

        return IsPalindrome(word.Substring(1, word.Length - 2));

    }
    public static int MCD(int a, int b)
    {
        if (b == 0) return a;

        return MCD(b, a % b);
    }

}