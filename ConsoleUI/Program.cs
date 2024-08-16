using ConsoleUI;
using DemoLibrary.Adaptees;
using DemoLibrary.Adapters;
using DemoLibrary.Interfaces;

StockDataProvider stockDataProvider = new StockDataProvider(); // Adaptee -> Does not implement IJsonData interface
IJsonData adapter = new XmlToJsonAdapter(stockDataProvider); // Adapter -> Implements IJsonData Wraps StockDataProvider
AnalyticsLibrary analyticsLibrary = new AnalyticsLibrary(); // Client -> Only collaborates with services that implement IJsonData interface

Console.WriteLine("Application receives XML data from Stock Data Provider.");

analyticsLibrary.ProcessData(adapter);