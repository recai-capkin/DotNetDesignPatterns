using System;


public class CryptoExchangeFacade
{
    private WalletManager _walletManager = new WalletManager();
    private TradingEngine _tradingEngine = new TradingEngine();
    private VerificationService _verificationService = new VerificationService();

    public void MakeTrade(int userId, string pair, string type, decimal amount, string currency, decimal walletAmount)
    {
        if (_verificationService.VerifyIdentity(userId))
        {
            _walletManager.Deposit(walletAmount, currency);
            _tradingEngine.PlaceOrder(pair, type, amount);
            _walletManager.Withdraw(walletAmount, currency);
        }
    }
}
