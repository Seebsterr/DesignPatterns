namespace DesignPatterns.Interpreter.InterpreterLexing
{
    public class Token
    {
        public Type Type { get; set; }
        public string Text { get; set; }

        public Token(Type type, string text)
        {
            Type = type;
            Text = text;
        }

        public override string ToString()
        {
            return $"'{Text}'";
        }
    }
}