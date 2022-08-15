

using AbstractFactoryDesignPattern.Class;
using AbstractFactoryDesignPattern.Class.AbstractFactory;
using AbstractFactoryDesignPattern.Class.ConcreteFactory;
using AbstractFactoryDesignPattern.Class.Product;

EnglandSpot englandSpot = new EnglandSpot();
englandSpot.ShowProperty();

ExchangeFactory exchangeFactory = new EnglandExchangeFactory();
exchangeFactory.CreateSpot();
Exchange e = exchangeFactory.CreateSpot();
e.ShowProperty();


exchangeFactory = new TurkeyExchangeFactory();
exchangeFactory.CreateEarn();
Exchange e2 = exchangeFactory.CreateEarn();
e2.ShowProperty();