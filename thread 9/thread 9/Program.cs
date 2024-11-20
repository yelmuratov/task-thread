using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread syncThread = new Thread(() =>
        {
            while (true)
            {
                Console.WriteLine("Syncing data...");
                Thread.Sleep(5000);
            }
        });
        syncThread.Start();
    }
}
