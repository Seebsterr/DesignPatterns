namespace DesignPatterns.Composite.NeuralNetworks
{
    public class Demo
    {
        public void Start()
        {
            var neuron = new Neuron();
            var neuron2 = new Neuron();

            neuron.ConnectTo(neuron2);

            var layer = new NeuronLayer();
            var layer2 = new NeuronLayer();

            neuron.ConnectTo(layer);
            layer.ConnectTo(layer2);
        }
    }
}