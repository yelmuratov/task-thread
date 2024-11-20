using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await Task.Delay(4000);
        Console.WriteLine("Report generated.");
    }
}
