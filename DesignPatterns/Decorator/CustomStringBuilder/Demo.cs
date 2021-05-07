namespace DesignPatterns.Decorator.CustomStringBuilder
{
    public class Demo
    {
        public void Start()
        {
            var codeBuilder = new CodeBuilder();
            codeBuilder
                .AppendLine("class Test")
                .AppendLine("{")
                .AppendLine("}");

            System.Console.WriteLine(codeBuilder);
        }
    }
}