using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Flyweight.RepeatingUsersNames
{
    public class User2
    {
        private List<string> _strings = new List<string>();
        private readonly int[] _names;

        public User2(string fullName)
        {
            int getOrAdd(string s)
            {
                int idx = _strings.IndexOf(s);
                if (idx != -1)
                {
                    return idx;
                }
                else
                {
                    _strings.Add(s);
                    return _strings.Count - 1;
                }
            }

            _names = fullName.Split(' ').Select(getOrAdd).ToArray();
        }

        public string FullName => string.Join(" ", _names);
    }
}