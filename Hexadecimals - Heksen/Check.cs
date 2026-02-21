using System;
using System.Collections.Generic;
using System.Text;

namespace Hexadecimals___Heksen
{
    internal class Check
    {
        public static char[] GetHexAllowedChars()
        {
            string[] allowed = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "#" };
            return allowed.Select(s => s[0]).ToArray();
        }
        public static bool Length(string input)
        {
            bool length = false;
            if(input.Length<8 && input.Length>2)
            {
                length = true;
            }
            else { Console.WriteLine("Your string must consist of 3 to 7 characters"); }
            return length;
        }
        public static bool Index0(string input)
        {
            bool indexZero = false;
            if (input[0] == '#')
            { indexZero = true; }
            else { Console.WriteLine("You must write # as the first element of your string for it to be a valid hexcolor"); }
            return indexZero;
        }
        public static bool ValidHex(string input)
        {
            char[] charAllowed = GetHexAllowedChars();
            bool allValid = true;
            foreach (char c in input)
            {
                bool valid = false;
                foreach (char i in charAllowed)
                {
                    if (c == i)
                    {
                        valid = true;
                        break;     //if c==i there is no need to go through the entire index of "allowed", therefore, break.
                    }

                }
                if (!valid)
                {
                    Console.WriteLine($"The character {c} is not a hexadeximal value");
                    allValid = false;
                }

            }
            return allValid;
        }
        
    }
}
