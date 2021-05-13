namespace DesignPatterns.Builder.FacadeBuilder
{
    public class Demo
    {
        public void Start()
        {
            var pb = new PersonBuilder();
            Person person = pb
              .Lives
                .At("123 London Road")
                .In("London")
                .WithPostcode("SW12BC")
              .Works
                .At("Fabrikam")
                .AsA("Engineer")
                .Earning(123000);

            System.Console.WriteLine(person);
        }
    }
}