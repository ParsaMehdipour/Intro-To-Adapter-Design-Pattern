using DemoLibrary.Interfaces;

namespace ConsoleUI;

// Analytics Library (Client)
public class AnalyticsLibrary
{
    public void ProcessData(IJsonData dataProvider)
    {
        string jsonData = dataProvider.GetJsonData();
        Console.WriteLine("Analytics Library receives JSON data");
        Console.WriteLine($"Analytics Library processing JSON data: {jsonData}");
        // Perform analysis on the JSON data
    }
}
