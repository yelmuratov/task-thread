using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task<long> sumTask = Task.Run(() =>
        {
            long sum = 0;
            for (int i = 1; i <= 1_000_000; i++)
                sum += i;
            return sum;
        });

        Console.WriteLine("Main thread continues...");
        long result = await sumTask;
        Console.WriteLine($"Sum: {result}");
    }
}
