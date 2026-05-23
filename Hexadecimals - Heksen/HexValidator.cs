using System;
using System.Collections.Generic;
using System.Text;

namespace Hexadecimals___Heksen
{
    internal class HexValidator
    {
        public void validate(string hex)
        {
            char[] validCharacters = new char[]
            {
                '0', '1', '2', '3', '4', '5', '6', '7', '8', '9','A', 'B', 'C', 'D', 'E', 'F'
            };


            bool hasHashtag = hex[0] == '#';
            bool is7chars = hex.Length == 7;
            bool validChars = true;

            for (int i = 1; i < hex.Length; i++)
            {
                bool valid = false;
                foreach(char c in validCharacters)
                {
                    if (c == hex[i])
                    {
                        valid = true;
                        break;
                    }        
                }
                if (!valid)
                {
                    validChars = false;
                }
            }

            if (hasHashtag && validChars && is7chars)
            {
                Console.WriteLine("The HEX value is valid");
            }
            if (!hasHashtag || !validChars || !is7chars)
            {
                Console.WriteLine("The HEX value is invalid");
                if (!hasHashtag)
                {
                    Console.WriteLine("A HEX value must start with #");
                }
                if (!is7chars)
                {
                    Console.WriteLine("A HEX value must be exactly 7 characters long");
                }
                if (!validChars)
                {
                    Console.WriteLine("HEX values only contains numbers and letters within the ranges 0-9 and A-Z");
                }
            }
        }
    }
}
