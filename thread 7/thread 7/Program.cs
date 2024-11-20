using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread primeThread = new Thread(() =>
        {
            for (int i = 2; i <= 100; i++)
            {
                if (IsPrime(i))
                    Console.WriteLine($"Prime: {i}");
            }
        });
        primeThread.Start();
    }

    static bool IsPrime(int number)
    {
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
