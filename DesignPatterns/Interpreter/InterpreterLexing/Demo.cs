using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interpreter.InterpreterLexing
{
    public class Demo
    {
        private static List<Token> Lex(string input)
        {
            var result = new List<Token>();

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '+':
                        result.Add(new Token(Type.Plus, "+"));
                        break;
                    case '-':
                        result.Add(new Token(Type.Minus, "-"));
                        break;
                    case '(':
                        result.Add(new Token(Type.LeftBracket, "("));
                        break;
                    case ')':
                        result.Add(new Token(Type.RightBracket, ")"));
                        break;
                    default:
                        var sb = new StringBuilder(input[i].ToString());
                        for (int j = i + 1; j < input.Length; ++j)
                        {
                            if (char.IsDigit(input[j]))
                            {
                                sb.Append(input[j]);
                                ++i;
                            }
                            else
                            {
                                result.Add(new Token(Type.Integer, sb.ToString()));
                                break;
                            }
                        }
                        break;
                }
            }
            return result;
        }

        public void Start()
        {
            var input = "(13+4)-(12+1)";
            var tokens = Lex(input);
            System.Console.WriteLine(string.Join("\t", tokens));
        }
    }
}