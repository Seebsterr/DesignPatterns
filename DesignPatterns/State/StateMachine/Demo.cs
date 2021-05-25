using System.Collections.Generic;
using static System.Console;

namespace DesignPatterns.State.StateMachine
{
    public class Demo
    {
        private static readonly Dictionary<PhoneState, List<(Trigger, PhoneState)>> _rules
        = new Dictionary<PhoneState, List<(Trigger, PhoneState)>>
        {
            [PhoneState.OffHook] = new List<(Trigger, PhoneState)>
            { (Trigger.CallDialed, PhoneState.Connecting) },

            [PhoneState.Connecting] = new List<(Trigger, PhoneState)>
            { (Trigger.HungUp, PhoneState.OffHook), (Trigger.CallConnected, PhoneState.Connected) },

            [PhoneState.Connected] = new List<(Trigger, PhoneState)>
            { (Trigger.LeftMessage, PhoneState.OffHook), (Trigger.HungUp, PhoneState.OffHook), (Trigger.PlacedOnHold, PhoneState.OnHold) },

            [PhoneState.OnHold] = new List<(Trigger, PhoneState)>
            { (Trigger.TakenOffHold, PhoneState.Connected), (Trigger.HungUp, PhoneState.OffHook) }
        };
         
        public void Start()
        {
            var state = PhoneState.OffHook;
            while (true)
            {
                WriteLine($"The phone is currently {state}");
                WriteLine("Select a trigger:");

                for (var i = 0; i < _rules[state].Count; i++)
                {
                    var (t, _) = _rules[state][i];
                    WriteLine($"{i}. {t}");
                }

                var input = int.Parse(ReadLine());
                var (_, s) = _rules[state][input];
                state = s;
            }
        }
    }
}