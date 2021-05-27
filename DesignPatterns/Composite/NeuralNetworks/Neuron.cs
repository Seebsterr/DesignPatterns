using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Composite.NeuralNetworks
{
    public class Neuron : IEnumerable<Neuron>
    {
        public float Value;
        public List<Neuron> In, Out;

        public IEnumerator<Neuron> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}