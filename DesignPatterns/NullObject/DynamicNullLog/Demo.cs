namespace DesignPatterns.NullObject.DynamicLog
{
    public class Demo
    {
        public void Start()
        {
            var log = Null<ILog>.Instance;
            log.Info("info");
            var ba = new BankAccount(log);
            ba.Deposit(100);
        }
    }
}