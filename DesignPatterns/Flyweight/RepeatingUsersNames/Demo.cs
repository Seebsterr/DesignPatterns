using JetBrains.dotMemoryUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Flyweight.RepeatingUsersNames
{
    [TestFixture]
    public class Demo
    {
        public void Start()
        {
            TestUser();
            TestUser2();
        }

        [Test]
        [DotMemoryUnit(FailIfRunWithoutSupport = false)]
        public void TestUser()
        {
            var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString());
            var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());

            var users = new List<User>();
            foreach (var name in firstNames)
            {
                foreach (var surname in lastNames)
                {
                    users.Add(new User($"{name} {surname}"));
                }
            }

            ForceGC();
            dotMemory.Check(memory =>
            {
                Console.WriteLine(memory.SizeInBytes);
            });
        }

        [Test]
        [DotMemoryUnit(FailIfRunWithoutSupport = false)]
        public void TestUser2()
        {
            var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString());
            var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());

            var users = new List<User2>();
            foreach (var name in firstNames)
            {
                foreach (var surname in lastNames)
                {
                    users.Add(new User2($"{name} {surname}"));
                }
            }

            ForceGC();
            dotMemory.Check(memory =>
            {
                Console.WriteLine(memory.SizeInBytes);
            });
        }

        private void ForceGC()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private string RandomString()
        {
            var random = new Random();
            return new string(
                Enumerable.Range(0, 10)
                .Select(i => (char)random.Next('a' + random.Next(26)))
                .ToArray());
        }
    }
}