namespace DesignPatterns.Memento.MementoClass
{
    public class Memento
    {
        public int Balance { get; }

        public Memento(int balance)
        {
            Balance = balance;
        }
    }
}