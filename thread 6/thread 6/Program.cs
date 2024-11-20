using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread reminderThread = new Thread(() =>
        {
            while (true)
            {
                Console.WriteLine("Eslatma: Bu yerda ishlaringizni tekshiring!");
                Thread.Sleep(10000); 
            }
        });
        reminderThread.Start();
    }
}
