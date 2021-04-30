using ImpromptuInterface;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DesignPatterns.Proxy.DynamicProxy
{
    public class Log<T> : DynamicObject where T : class, new()
    {
        private const int INITIAL_COUNTER_NUMBER = 0;
        private readonly T _subject;
        private Dictionary<string, int> _methodCallCount;

        public Log(T subject)
        {
            _subject = subject;
            _methodCallCount = new Dictionary<string, int>();
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            Console.WriteLine($"Invoking {_subject.GetType().Name}.{binder.Name} " +
                $"with arguments [{string.Join(",", args)}]");

            if (!_methodCallCount.ContainsKey(binder.Name))
            {
                _methodCallCount.Add(binder.Name, INITIAL_COUNTER_NUMBER);
            }

            _methodCallCount[binder.Name]++;
            result = _subject.GetType().GetMethod(binder.Name).Invoke(_subject, args);
            return true;
        }

        public static I As<I>() where I : class
        {
            if (!typeof(I).IsInterface)
            {
                throw new ArgumentException("I must be an interface type");
            }

            return new Log<T>(new T()).ActLike<I>();
        }

        public string Info
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var kv in _methodCallCount)
                {
                    sb.AppendLine($"{kv.Key} called {kv.Value} time(s)");
                }

                return sb.ToString();
            }
        }

        public override string ToString()
        {
            return $"{Info}{_subject}";
        }
    }
}