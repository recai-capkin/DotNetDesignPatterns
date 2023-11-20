using System;

public interface IWalletManager
{
    void Deposit(decimal amount, string currency);
    void Withdraw(decimal amount, string currency);
}
