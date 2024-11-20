using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread imageThread = new Thread(() =>
        {
            Console.WriteLine("Processing image...");
            Thread.Sleep(3000);
            Console.WriteLine("Image processed.");
        });
        imageThread.Start();
    }
}
