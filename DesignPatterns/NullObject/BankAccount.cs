namespace DesignPatterns.NullObject
{
    public class BankAccount
    {
        private ILog _logger;
        private int _balance;

        public BankAccount(ILog logger)
        {
            _logger = logger;
        }

        public void Deposit(int amount)
        {
            _balance += amount;
            _logger?.Info($"Deposited {amount}, balance is now {_balance}");
        }
    }
}