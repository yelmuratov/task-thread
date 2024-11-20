using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string result = await CheckInventory();
        Console.WriteLine(result);
    }

    static async Task<string> CheckInventory()
    {
        await Task.Delay(2000);
        return "Item is in stock.";
    }
}
