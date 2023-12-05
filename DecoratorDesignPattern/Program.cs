using DecoratorDesignPattern.Classes.Abstract.Decorator;
using DecoratorDesignPattern.Classes.Decorator;
using DecoratorDesignPattern.Classes;
using DecoratorDesignPattern.Classes.Abstract;

CryptoCurrency myCurrency = new MineableCurrency();

// Madencilik işlevlerini eklemek için dekoratör kullanma
CryptoCurrencyDecorator decoratedCurrency = new MineableCurrencyDecorator(myCurrency);

// İşlemleri gerçekleştirme
decoratedCurrency.Send(100, "wallet12345");

MineableCurrencyDecorator decoratedCurrencyMineable = new MineableCurrencyDecorator(myCurrency);
decimal newDifficulty = decoratedCurrencyMineable.changeDifficulty();
Console.WriteLine($"Yeni zorluk derecesi: {newDifficulty}");

// Blok boyutunu değiştirme
decimal newBlockSize = decoratedCurrencyMineable.changeBlockSize(50000); // Örnek blok boyutu artışı
Console.WriteLine($"Yeni blok boyutu: {newBlockSize} bytes");

// Madencilik işlemi
string miningResult = ((MineableCurrency)myCurrency).RunMining(1000); // Örnek hash oranı
Console.WriteLine(miningResult);