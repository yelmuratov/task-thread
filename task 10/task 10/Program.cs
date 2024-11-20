using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await Task.Delay(3000);
        Console.WriteLine("Weather data fetched: Sunny, 25°C");
    }
}
