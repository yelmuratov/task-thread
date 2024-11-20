using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread countdownThread = new Thread(() =>
        {
            int seconds = 10;
            while (seconds > 0)
            {
                Console.WriteLine($"Qolgan vaqt: {seconds} soniya");
                Thread.Sleep(1000);
                seconds--;
            }
            Console.WriteLine("Vaqt tugadi!");
        });
        countdownThread.Start();
    }
}
