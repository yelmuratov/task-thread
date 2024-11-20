using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Random random = new Random();
        Thread stockThread = new Thread(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Stock price: ${random.Next(100, 200)}");
                Thread.Sleep(1000);
            }
        });
        stockThread.Start();
    }
}
