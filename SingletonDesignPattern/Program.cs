

using SingletonDesignPattern.Classes;

BitcoinWallet bitcoinWallet = BitcoinWallet.Instance();
BitcoinWallet bitcoinWallet1 = BitcoinWallet.Instance();

if (bitcoinWallet == bitcoinWallet1)
{
    Console.WriteLine("Singleton örneği çalışıyor");
}
else
{
    Console.WriteLine("Singleton örneği çalışmıyor");
}