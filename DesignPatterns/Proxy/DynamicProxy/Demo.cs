using System;

namespace DesignPatterns.Proxy.DynamicProxy
{
    public class Demo
    {
        public void Start()
        {
            var ba = Log<BankAccount>.As<IBankAccount>();

            ba.Deposit(100);
            ba.Withdraw(50);

            Console.WriteLine(ba);
        }
    }
}
