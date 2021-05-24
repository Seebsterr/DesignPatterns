using System.Collections.Generic;

namespace DesignPatterns.Memento.MementoClass
{
    public class BankAccount
    {
        private List<Memento> _changes = new List<Memento>();
        private int _current;
        private int _balance;

        public BankAccount(int balance)
        {
            _balance = balance;
            _changes.Add(new Memento(balance));
        }

        public Memento Deposit(int amount)
        {
            _balance += amount;
            var memento = new Memento(_balance);
            _changes.Add(memento);
            ++_current;
            return memento;
        }

        public Memento Restore(Memento memento)
        {
            _balance = memento.Balance;
            _changes.Add(memento);
            return memento;
        }

        public Memento Undo()
        {
            if (_current > 0)
            {
                var memento = _changes[--_current];
                _balance = memento.Balance;
                return memento;
            }
            return null;
        }

        public Memento Redo()
        {
            if (_current + 1 < _changes.Count)
            {
                var memento = _changes[++_current];
                _balance = memento.Balance;
                return memento;
            }
            return null;
        }

        public override string ToString()
        {
            return _balance.ToString();
        }
    }
}