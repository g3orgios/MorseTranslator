using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<char, string> morseCode = new Dictionary<char, string>()
        {
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'0', "-----"},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."}
        };

        Console.WriteLine("Enter '1' to translate text to Morse code or '2' to translate Morse code to text:");
        int selection = int.Parse(Console.ReadLine());

        if (selection == 1)
        {
            Console.WriteLine("Enter the text you want to translate to Morse code:");
            string text = Console.ReadLine().ToUpper();

            string morseText = "";

            foreach (char c in text)
            {
                if (morseCode.ContainsKey(c))
                {
                    morseText += morseCode[c] + " ";
                }
                else if (c == ' ')
                {
                    morseText += "   ";
                }
            }

            Console.WriteLine("Morse code: " + morseText);
        }
        else if (selection == 2)
        {
            Console.WriteLine("Enter the Morse code you want to translate to text:");
            string morseText = Console.ReadLine();

            string text = "";

            foreach (string morseChar in morseText.Split(' '))
            {
                if (morseChar == "")
                {
                    text += " ";
                }
                else
                {
                    foreach (KeyValuePair<char, string> kvp in morseCode)
                    {
                        if (kvp.Value == morseChar)
                        {
                            text += kvp.Key;
                        }
                    }
                }
            }

            Console.WriteLine("Text: " + text);
        }
        else
        {
            Console.WriteLine("Invalid selection. Please enter '1' or '2'.");
        }

        Console.ReadLine();
    }
}
