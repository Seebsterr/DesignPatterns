namespace DesignPatterns.Command
{
    public class BankAccount
    {
        private int _balance;
        private readonly int _overdraftLimit = -500;

        public void Deposit(int amount)
        {
            _balance += amount;
            System.Console.WriteLine($"Deposited ${amount}, balance is now {_balance}");
        }

        public bool Withdraw(int amount)
        {
            if (_balance - amount >= _overdraftLimit)
            {
                _balance -= amount;
                System.Console.WriteLine($"Withdraw ${amount}, balance is now {_balance}");
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"balance is {_balance}";
        }
    }
}