// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace cChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OldPhonePad("33#"));
            Console.WriteLine(OldPhonePad("227*#"));
            Console.WriteLine(OldPhonePad("4433555 555666#"));
            Console.WriteLine(OldPhonePad("8 88777444666*664#"));
            Console.WriteLine(OldPhonePad("44444#"));
            Console.WriteLine(OldPhonePad("777777#"));
            Console.WriteLine(OldPhonePad("999999#"));
            Console.WriteLine(OldPhonePad("1"));
            Console.WriteLine(OldPhonePad("#"));
            Console.WriteLine(OldPhonePad("asd#"));
            Console.WriteLine(OldPhonePad("123asd123#"));
            Console.WriteLine(OldPhonePad("11#"));
            Console.WriteLine(OldPhonePad("111#"));
            Console.WriteLine(OldPhonePad("4433555 555666 096667775553#"));
            Console.WriteLine(OldPhonePad("3#"));
            Console.WriteLine(OldPhonePad("777778888#"));
        }

        public static string OldPhonePad(string input)
        {

            int runningTotal = 0; // Keep track of consecutive key presses
            StringBuilder outputString = new StringBuilder(); // String concatenation
            char currentKey = '\0'; // Current key being processed

            for (int i = 0; i < input.Length; i++) // Iterate through each character in the input string
            {
                if (currentKey == input[i]) runningTotal++;
                else
                {
                    if (currentKey == '#') break; // In case a string has multiple '#' characters
                    else if (currentKey == '0') outputString.Append(' ');
                    else if (Char.IsDigit(currentKey)) outputString.Append(GetCharFromKeyPress(currentKey, runningTotal));
                    else if (currentKey == '*' && outputString.Length > 0) outputString.Length--;

                    currentKey = input[i];
                    runningTotal = 0;
                }
            }

            return outputString.ToString();
        }

        private static char GetCharFromKeyPress(char key, int count) // Map key presses to characters
        {
            if (key == '7' || key == '9') count = count % 4; // If key pressed more than needed, wrap around
            else count = count % 3;

            switch (key)
            {
                case '1':
                    return "&'("[count];
                case '2':
                    return "ABC"[count];
                case '3':
                    return "DEF"[count];
                case '4':
                    return "GHI"[count];
                case '5':
                    return "JKL"[count];
                case '6':
                    return "MNO"[count];
                case '7':
                    return "PQRS"[count];
                case '8':
                    return "TUV"[count];
                case '9':
                    return "WXYZ"[count];
                default:
                    return '\0';
            }
        }
    } 
}