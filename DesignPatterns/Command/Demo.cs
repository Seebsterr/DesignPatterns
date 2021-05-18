using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Command
{
    public class Demo
    {
        public void Start()
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand>
            {
                new BankAccountCommand(ba, Action.Deposit, 100),
                new BankAccountCommand(ba, Action.Withdraw, 50)
            };

            commands.ForEach(x => x.Call());
            Enumerable.Reverse(commands).ToList().ForEach(x => x.Undo());

            System.Console.WriteLine(ba);
        }
    }
}