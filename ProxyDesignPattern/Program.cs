using ProxyDesignPattern.Classes.Proxy;
using ProxyDesignPattern.Interfaces;


IBuyCoin buyCoin = new ProxyExchange();
Console.WriteLine(buyCoin.BuyCoin(5,"Holo"));

Console.WriteLine(buyCoin.BuyCoin(15,"Bitcoin"));