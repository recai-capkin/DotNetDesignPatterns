using CompositeDesignPattern;
using CompositeDesignPattern.Services;

var btc = new CryptoCurrency("Bitcoin", 45000);
var eth = new CryptoCurrency("Ethereum", 3000);

var myPortfolio = new CryptoPortfolio("My Investment Portfolio");
myPortfolio.AddCurrency(btc);
myPortfolio.AddCurrency(eth);

// Bireysel kripto para birimi bilgilerini ve portföy bilgilerini görüntüle
myPortfolio.DisplayInfo();