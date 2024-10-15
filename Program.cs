using System.Numerics;

public class Program
{
    public static void Main(string[] args)
    {
        CalculateFibonacciSequenceUpTo(10);       
    }

    public static void CalculateFibonacciSequenceUpTo(int n) 
    {
        BigInteger a = 0;
        BigInteger b = 1;

        for (int i = 1; i <= n; i++)
        {
            a = 0;
            b = 1;

            if (i <= 1)
            {
                Console.WriteLine($"{i}: {i}");
                continue;
            }

            for (int y = 2; y <= i; y++)
            {
                BigInteger temp = a + b;
                a = b;
                b = temp;
            }

            Console.WriteLine($"{i}: {b}");
        }
    }

    /// <summary>
    /// Not suitable for long iterations because of its recursive nature.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public static int RecursiveFibonacci(int n) 
    {
        if (n <= 1)
            return n;

        return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
    }

    /// <summary>
    /// Binet's formula to calculate any Fibonacci number; However, it may introduce some innacuracy
    /// Please visit https://artofproblemsolving.com/wiki/index.php/Binet%27s_Formula for more information.
    /// </summary>
    public static long FibonacciBinet(int n)
    {
        double golden_ration = (1 + Math.Sqrt(5)) / 2;
        double fibonacciNumber = (Math.Pow(golden_ration, n) - Math.Pow(1 - golden_ration, n)) / Math.Sqrt(5);

        return (long)Math.Round(fibonacciNumber);
    }

    /// <summary>
    /// Function suitable for large iterations as we avoid recursion. 
    /// It has to use BigInteger becuase the numbers can grow very quickly
    /// </summary>
    public static BigInteger Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        BigInteger a = 0;
        BigInteger b = 1;
        BigInteger temp = BigInteger.Zero;

        for (int i = 2; i <= n; i++)
        {
            temp = a + b;
            a = b;
            b = temp;
        }

        return b;
    }
}