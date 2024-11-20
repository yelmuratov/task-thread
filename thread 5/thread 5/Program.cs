using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Random random = new Random();
        Thread sensorThread = new Thread(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Sensor temperature: {random.Next(-10, 35)}°C");
                Thread.Sleep(2000); 
            }
        });
        sensorThread.Start();
    }
}
