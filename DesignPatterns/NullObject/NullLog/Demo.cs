using Autofac;

namespace DesignPatterns.NullObject.NullLog
{
    public class Demo
    {
        public void Start()
        {
            var cb = new ContainerBuilder();
            cb.RegisterType<BankAccount>();
            cb.RegisterType<NullLog>().As<ILog>();
            using (var c = cb.Build())
            {
                var ba = c.Resolve<BankAccount>();
                ba.Deposit(100);
            }
        }
    }
}