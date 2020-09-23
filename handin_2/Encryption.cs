using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace handin_2
{
    public class Encryption
    {
        public static char Cipherify(char code, int key)
        {
            if (!char.IsLetter(code))
                return code;

            char offset = char.IsUpper(code) ? 'A' : 'a';
            return (char)((((code + key) - offset) % 26) + offset);
        }

        public static string Hash(string input, int key)
        {
            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                output += Cipherify(input[i], key);
            }

            return output;
        }
    }
}