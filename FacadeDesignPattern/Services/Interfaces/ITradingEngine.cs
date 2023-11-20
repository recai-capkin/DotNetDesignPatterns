using System;

public interface ITradingEngine
{
    void PlaceOrder(string pair, string type, decimal amount);
}
