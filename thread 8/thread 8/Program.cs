using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread receiver = new Thread(() =>
        {
            while (true)
            {
                Console.WriteLine("Listening for messages...");
                Thread.Sleep(2000);
            }
        });

        Thread sender = new Thread(() =>
        {
            while (true)
            {
                Console.WriteLine("Sending a message...");
                Thread.Sleep(3000);
            }
        });

        receiver.Start();
        sender.Start();
    }
}
