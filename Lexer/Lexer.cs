namespace eigen_parser;

public class Lexer
{
    private List<Token> tokens = new();
    private int cursor = 0;
    private string input;


    public Lexer(string input)
    {
    }

    public Boolean hasMoreTokens()
    {
        return this.cursor < input.Length;
    }
    
    public
}