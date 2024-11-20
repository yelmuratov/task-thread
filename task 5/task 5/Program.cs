using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string profile = await FetchProfile();
        Console.WriteLine(profile);
    }

    static async Task<string> FetchProfile()
    {
        await Task.Delay(3000);
        return "User Profile: John Doe";
    }
}
