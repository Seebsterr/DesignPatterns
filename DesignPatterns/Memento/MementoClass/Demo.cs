using static System.Console;

namespace DesignPatterns.Memento.MementoClass
{
    public class Demo
    {
        public void Start()
        {
            var bankAccount = new BankAccount(100);
            WriteLine(bankAccount);
            var memento = bankAccount.Deposit(50);
            var memento2 = bankAccount.Deposit(100);
            WriteLine(bankAccount);
            bankAccount.Restore(memento);
            WriteLine(bankAccount);
            bankAccount.Restore(memento2);
            WriteLine(bankAccount);

            bankAccount = new BankAccount(100);
            bankAccount.Deposit(50);
            bankAccount.Deposit(25);
            WriteLine(bankAccount);
            bankAccount.Undo();
            WriteLine($"Undo 1: {bankAccount}");
            bankAccount.Undo();
            WriteLine($"Undo 2: {bankAccount}");
            bankAccount.Redo();
            WriteLine($"Redo 2: {bankAccount}");
        }
    }
}