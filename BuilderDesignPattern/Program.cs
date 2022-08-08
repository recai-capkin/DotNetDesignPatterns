

using BuilderDesignPattern;
using BuilderDesignPattern.Class;
using BuilderDesignPattern.Class.Builder;
using BuilderDesignPattern.Class.Builder.Coins;

//Builder Tanımlandı
CryptoCurrencyBuilder cryptoCurrencyBuilder;
//Exchange Tanımlandı
Exchange market = new Exchange();
//Bitcoin tanımladı
cryptoCurrencyBuilder = new BitcoinBuilder();
//Üretildi
market.Construct(cryptoCurrencyBuilder);
//Override edilmiş ToString ile yazdırıldı
Console.WriteLine(cryptoCurrencyBuilder.CryptoCurrency.ToString());


cryptoCurrencyBuilder = new MinaBuilder();
market.Construct(cryptoCurrencyBuilder);
Console.WriteLine(cryptoCurrencyBuilder.CryptoCurrency.ToString());
