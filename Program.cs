using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MissingNumberApp;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddTransient<IMissingNumberFinder, SumBasedMissingNumberFinder>();
        services.AddTransient<MissingNumberProcessor>();
    })
    .Build();

try
{
    Console.WriteLine("=== Missing Number Finder ===");
    Console.WriteLine("This application finds the missing number in a sequence from 0 to n.");
    var processor = host.Services.GetRequiredService<MissingNumberProcessor>();
    var exampleArray = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

    Console.WriteLine($"Sample input array: {string.Join(", ", exampleArray)}");

    processor.Process(exampleArray);
}
catch (Exception ex)
{
    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
}

Console.ReadLine();



