namespace DesignPatterns.Builder.FacadeBuilder
{
    public class PersonBuilder
    {
        protected Person Person { get; set; } = new Person();

        public PersonAddressBuilder Lives => new PersonAddressBuilder(Person);
        public PersonJobBuilder Works => new PersonJobBuilder(Person);

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.Person;
        }
    }
}