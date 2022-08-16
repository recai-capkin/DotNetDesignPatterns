


using FactoryDesignPattern.Classes;
using FactoryDesignPattern.Interfaces;

IErc20 erc20 = Erc20Factory.getToken("holo");
Console.WriteLine(erc20.name());
Console.WriteLine(erc20.mintingFinished());