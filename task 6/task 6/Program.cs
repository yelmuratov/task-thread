using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await Task.Delay(2000);
        Console.WriteLine("Email sent.");
    }
}
