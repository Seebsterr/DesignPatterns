namespace DesignPatterns.Memento.MementoClass
{
    public class Demo
    {
        public void Start()
        {
            var bankAccount = new BankAccount(100);
            System.Console.WriteLine(bankAccount);

            var memento = bankAccount.Deposit(50);
            var memento2 = bankAccount.Deposit(100);
            System.Console.WriteLine(bankAccount);

            bankAccount.Restore(memento);
            System.Console.WriteLine(bankAccount);

            bankAccount.Restore(memento2);
            System.Console.WriteLine(bankAccount);
        }
    }
}