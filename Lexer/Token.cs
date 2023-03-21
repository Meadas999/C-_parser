using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Linq;

namespace eigen_parser;

public class Token
{
    public TokenType tokenType { get; set; }
    
    public int bindingPower { get; }
    public string value { get; set; }

    public Token(TokenType tokenType, string value)
    {
        this.tokenType = tokenType;
        if (tokenType == TokenType.Number && value.All(char.IsDigit))
        {
            this.value = value;
            this.bindingPower = 0;
        }
    }

    
    

    
}