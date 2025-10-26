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
            Console.WriteLine(OldPhonePad("777778888"));
            Console.WriteLine(OldPhonePad("#####"));
            Console.WriteLine(OldPhonePad("            #"));
        }

        public static string OldPhonePad(string input)
        {

            int runningTotal = 0; // Keep track of consecutive key presses.
            StringBuilder outputString = new StringBuilder(); // String concatenation.
            char currentKey = '\0'; // Current key being processed.

            foreach (char currentChar in input) // Since I am not assigning variables to the indexes, using foreach is fine.
            {

                if (currentKey == currentChar) // If the same key is pressed, increment the count.
                {
                    runningTotal++;
                    continue;
                }
                else if (currentKey == '#') { break; } // In case a string has multiple '#' characters.
                else if (currentKey == '*' && outputString.Length > 0) { outputString.Length--; } // Backspace deletion (Only allow backspace if there is something to delete).
                else if (KeyMappings.TryGetValue(currentKey, out string addedChar)) // Once a different key is pressed, process the previous key (Strings not in the dictionary get assigned as Null).
                {
                    if (currentKey == '7' || currentKey == '9') { outputString.Append(addedChar[runningTotal % 4]); } // If key pressed more than needed, wrap around
                    else { outputString.Append(addedChar[runningTotal % 3]); }
                }
                currentKey = currentChar; // Process the next key.
                runningTotal = 0; // Reset the count for the new key.
            }

            if (currentKey == '#') { return outputString.ToString(); }
            return String.Empty; // If string does not end with '#', return empty string.
        }

        private static readonly Dictionary<char, string> KeyMappings = new Dictionary<char, string> // Replacing switch statement with dictionary to decrease code size.
        {
            { '0', "    "}, // Using this instead of an if statement for 0 in order to reduce code size.
            { '1', "&'(" },
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" }
        };
    } 
}