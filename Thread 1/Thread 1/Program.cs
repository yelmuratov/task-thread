using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread calculationThread = new Thread(BackgroundCalculation);
        calculationThread.Start();
        Console.WriteLine("Asosiy oqim boshqa ishlarni davom ettirmoqda...");
    }

    static void BackgroundCalculation()
    {
        long sum = 0;
        for (int i = 1; i <= 1_000_000; i++)
        {
            sum += i;
        }
        Console.WriteLine($"1 dan 1,000,000 gacha yig‘indi: {sum}");
    }
}
