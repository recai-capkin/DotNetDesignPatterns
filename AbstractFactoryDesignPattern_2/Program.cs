using AbstractFactoryDesignPattern_2.Clients;
using AbstractFactoryDesignPattern_2.Factories;

var usaFactory = new USAExchangeFactory();
var usaClient = new CryptoExchangeClient(usaFactory);
usaClient.ExecuteTrade(1000m);

var euFactory = new EUExchangeFactory();
var euClient = new CryptoExchangeClient(euFactory);
euClient.ExecuteTrade(1000m);