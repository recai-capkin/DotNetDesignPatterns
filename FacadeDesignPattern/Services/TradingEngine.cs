using System;

public class TradingEngine : ITradingEngine
{
    public void PlaceOrder(string pair, string type, decimal amount)
    {
        Console.WriteLine($"Placed a {type} order for {amount} of {pair}.");
    }
}
