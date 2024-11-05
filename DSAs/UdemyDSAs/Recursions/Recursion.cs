namespace UdemyDSAs.Recursions;

public static class Recursion
{
    public static void Calculate(int n)
    {
        while (n > 0)
        {
            int k = n * n;
            Console.WriteLine(k);
            n -= 1;
        }
    }

    public static void HeadCalculate(int n)
    {
        if (n > 0)
        {
            HeadCalculate(n - 1);
            int k = n * n;
            Console.WriteLine(k);
        }
    }


    public static void TreeCalculate(int n) //O(2^n)
    {
        if (n > 0)
        {
            TreeCalculate(n - 1);
            int k = n * n;
            Console.WriteLine(k);
            TreeCalculate(n - 1);
        }
    }

    public static int SumOfNumbers(int n)
    {
        if (n == 0) return 0;
        return SumOfNumbers(n - 1) + n;
    }

    public static int FactorialOfNumber(int n)
    {
        if (n == 0) return 1;
        return FactorialOfNumber(n - 1) * n;
    }
}