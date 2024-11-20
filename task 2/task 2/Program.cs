using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string result = await ProcessOrder();
        Console.WriteLine(result);
    }

    static async Task<string> ProcessOrder()
    {
        await Task.Delay(2000);
        return "Order processed.";
    }
}
