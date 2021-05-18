namespace DesignPatterns.Command
{
    public class BankAccountCommand
    {
        private BankAccount _bankAccount;
        private readonly Action _action;
        private readonly int _amount;
        private bool _succeded;

        public BankAccountCommand(BankAccount bankAccount, Action action, int amount)
        {
            _bankAccount = bankAccount;
            _action = action;
            _amount = amount;
        }

        public void Call()
        {
            switch (_action)
            {
                case Action.Deposit:
                    _succeded = true;
                    _bankAccount.Deposit(_amount);
                    break;
                case Action.Withdraw:
                    _succeded = _bankAccount.Withdraw(_amount);
                    break;
            }
        }

        public void Undo()
        {
            if(!_succeded)
            {
                return;
            }

            switch (_action)
            {
                case Action.Deposit:
                    _bankAccount.Withdraw(_amount);
                    break;
                case Action.Withdraw:
                    _bankAccount.Deposit(_amount);
                    break;
            }
        }
    }
}