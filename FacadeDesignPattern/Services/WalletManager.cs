using System;

public class WalletManager : IWalletManager
{
    public void Deposit(decimal amount, string currency)
    {
        Console.WriteLine($"Deposited {amount} {currency} to the wallet.");
    }

    public void Withdraw(decimal amount, string currency)
    {
        Console.WriteLine($"Withdrew {amount} {currency} from the wallet.");
    }
}
