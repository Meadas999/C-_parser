﻿using System;

namespace eigen_parser // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Token token = new(TokenType.String);
            Console.WriteLine(token.value);
        }
    }
}