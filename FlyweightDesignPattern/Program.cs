using FlyweightDesignPattern.Flywieght;

CryptoCurrencyFactory factory = new CryptoCurrencyFactory();

var btc = factory.GetCryptoCurrency("BTC");
btc.DisplayPrice(50000);

var eth = factory.GetCryptoCurrency("ETH");
eth.DisplayPrice(4000);

// BTC için Flyweight nesnesini yeniden kullanma
btc.DisplayPrice(51000);