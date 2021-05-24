namespace DesignPatterns.Memento.MementoClass
{
    public class BankAccount
    {
        private int _balance;

        public BankAccount(int balance)
        {
            _balance = balance;
        }

        public Memento Deposit(int balance)
        {
            _balance += balance;
            return new Memento(_balance);
        }

        public void Restore(Memento memento)
        {
            _balance = memento.Balance;
        }

        public override string ToString()
        {
            return _balance.ToString();
        }
    }
}