using DemoLibrary.Adaptees;
using DemoLibrary.Interfaces;
using System.Text.Json;
using System.Xml.Linq;

namespace DemoLibrary.Adapters;

// The Adapter makes the Adaptee's interface compatible with the Target's interface.
public class XmlToJsonAdapter : IJsonData
{
    private readonly StockDataProvider _stockDataProvider;

    public XmlToJsonAdapter(StockDataProvider stockDataProvider)
    {
        _stockDataProvider = stockDataProvider;
    }

    public string GetJsonData()
    {
        string xmlData = _stockDataProvider.GetStockDataXml();

        Console.WriteLine($"XML data: {xmlData}");

        Console.WriteLine("XML to JSON Adapter converts the data.");

        XDocument doc = XDocument.Parse(xmlData);

        var jsonObject = new
        {
            symbol = doc.Root?.Element("symbol")?.Value ?? "Unknown",
            price = decimal.TryParse(doc.Root?.Element("price")?.Value, out var parsedPrice)
             ? parsedPrice
             : 0m
        };

        return JsonSerializer.Serialize(jsonObject);
    }
}
