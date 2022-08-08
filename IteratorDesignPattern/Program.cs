



using IteratorDesignPattern.Classes;
using IteratorDesignPattern.Classes.Collections;
using IteratorDesignPattern.Classes.Iterators;

CryptoCurrencyCollection  cryptoCurrency = new CryptoCurrencyCollection();
cryptoCurrency[0] = new CryptoCurrency { CurrencyId = 1, CurrencyName = "Bitcoin", CurrencyPrice = 20979m };
cryptoCurrency[1] = new CryptoCurrency { CurrencyId = 2, CurrencyName = "Holo", CurrencyPrice = 0.002650m };
cryptoCurrency[2] = new CryptoCurrency { CurrencyId = 3, CurrencyName = "Mina", CurrencyPrice = 0.80m };

CryptoCurrencyIterator cryptoCurrencyIterator = new CryptoCurrencyIterator(cryptoCurrency);

cryptoCurrencyIterator.StepSize = 1;

for (CryptoCurrency coin = cryptoCurrencyIterator.First(); cryptoCurrencyIterator.IsContinue;coin = cryptoCurrencyIterator.MoveNext())
{
    Console.WriteLine(coin.ToString());
}
