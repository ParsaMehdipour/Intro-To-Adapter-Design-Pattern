namespace DemoLibrary.Adaptees;

// The Adaptee contains some useful behavior, but its interface is
// incompatible with the existing client code. The Adaptee needs some
// adaptation before the client code can use it.
public class StockDataProvider
{
    public string GetStockDataXml()
    {
        return "<stock><symbol>AAPL</symbol><price>150.25</price></stock>";
    }
}
