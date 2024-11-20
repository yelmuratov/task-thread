using System;
using System.Threading;

class Program
{
    static void Main()
    {
        string[] files = { "file1.txt", "file2.txt", "file3.txt" };
        Thread fileProcessingThread = new Thread(() =>
        {
            foreach (var file in files)
            {
                Console.WriteLine($"Processing {file}...");
                Thread.Sleep(1000); 
            }
            Console.WriteLine("Barcha fayllar qayta ishlash tugadi.");
        });
        fileProcessingThread.Start();
    }
}
