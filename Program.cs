using System.Numerics;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Writing first 10 Fibonacci numbers");
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(RecursiveFibonacci(i));
        }

        Console.WriteLine("----------------------");
        Console.WriteLine("Writing first 500 Fibonacci numbers");
        for (int i = 0; i <= 500; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }

        Console.WriteLine("--------------");
        Console.WriteLine("Writing first 10 Fibonacci numbers by using Binet's formula");
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(FibonacciBinet(i));
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