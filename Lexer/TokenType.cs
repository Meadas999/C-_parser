using System.ComponentModel;

namespace eigen_parser;

public enum TokenType
{
    String,
    Name,
    Number,
    Operator,
    Binary,
    Unary,
    Statement,
}