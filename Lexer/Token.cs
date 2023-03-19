using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace eigen_parser;

public class Token
{
    public TokenType tokenType { get; set; }
    public string value { get; set; }

    public Token(TokenType tokenType)
    {
        this.tokenType = tokenType;
        setValue();
    }

    private void setValue()
    {
        switch (this.tokenType)
        {
            case TokenType.String: 
                this.value = "STRING";
                break;
             
        }
    }
    

    
}