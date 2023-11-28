// Bir kripto para biriminin prototipini oluştur
using PrototypeDesignPattern.Prototypes;
using PrototypeDesignPattern.Prototypes.Services;

var bitcoinPrototype = new CryptoCurrency("BTC", 45000m);

// Bir hesabın prototipini oluştur ve portföyüne BTC ekle
var accountPrototype = new ExchangeAccount("12345");
accountPrototype.Portfolio.Add(bitcoinPrototype);

// Prototip hesabı klonla ve klonlanmış hesapta değişiklik yap
var clonedAccount = (ExchangeAccount)accountPrototype.Clone();
clonedAccount.AccountId = "67890";
clonedAccount.Portfolio[0].CurrentPrice = 47000m; // Bitcoin fiyatını güncelle

// Orjinal ve klonlanmış hesap bilgilerini göster
accountPrototype.DisplayAccountInfo();
clonedAccount.DisplayAccountInfo();