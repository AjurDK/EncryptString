using System;
using System.Collections.Generic;

namespace EncryptProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = "Ab1-wx2";
            var key = 4;

            var numbers = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            var alphabets = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            var result = string.Empty;

            foreach (char charc in word)
            {
                if (Char.IsLetterOrDigit(charc))
                {
                    result += alphabets.GetEncryptedChar(charc, key);
                    result += numbers.GetEncryptedChar(charc, key);
                }
                else
                {
                    result += charc.ToString();
                }
            }

            Console.WriteLine(word);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
