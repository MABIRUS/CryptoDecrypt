﻿using System.Text;
using System.Text.RegularExpressions;

namespace CryptoDecrypt.Model
{
    class Cipher
    {
        public string Text { get; set; }

        public Cipher(string text) => Text = text;

        Regex MorseCipherRegex = new Regex(@"^[.-]+( +[.-]+)*$");

        private static readonly Dictionary<char, string> morseDictionary = new Dictionary<char, string>()
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."},
            {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
            {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"},
            {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
            {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"},
            {'Z', "--.."},
            {'1', ".----"}, {'2', "..---"}, {'3', "...--"}, {'4', "....-"}, {'5', "....."},
            {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."}, {'0', "-----"},
            {',', "--..--"}, {'.', ".-.-.-"}, {'?', "..--.."}, {'!', "-.-.--"}, {'\'', ".----."},
            {'"', ".-..-."}, {'(', "-.--."}, {')', "-.--.-"}, {'&', ".-..."}, {':', "---..."},
            {';', "-.-.-."}, {'=', "-...-"}, {'+', ".-.-."}, {'-', "-....-"}, {'_', "..--.-"},
            {'/', "-..-."}, {'@', ".--.-."}
        };

        public void MorseCipher()
        {
            if (MorseCipherRegex.IsMatch(Text))
            {
                Dictionary<string, char> reverseMorseDictionary = morseDictionary.ToDictionary(x => x.Value, x => x.Key);

                string[] words = Text.Split("   ");
                StringBuilder stringBuilder = new StringBuilder();
                foreach (string word in words)
                {
                    string[] letters = word.Split(' ');
                    foreach (string letter in letters)
                        stringBuilder.Append(reverseMorseDictionary[letter]);

                    stringBuilder.Append(' ');
                }
                Text = stringBuilder.ToString().Trim();

            }

            else
            {
                string[] strings = Text.Split();
                StringBuilder stringBuilder = new StringBuilder();
                foreach (string s in strings)
                {
                    foreach (char c in s.ToUpper())
                    {
                        stringBuilder.Append(morseDictionary[c] + ' ');
                    }
                    stringBuilder.Append("  ");
                }
                Text = stringBuilder.ToString().Trim();
            }
        }

        public void CaesarCipher(int key)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char letter in Text.ToUpper())
            {
                if (letter >= 'A' && letter <= 'Z')
                {
                    int shifted = letter + key;
                    if (shifted > 'Z')
                        shifted -= 26;
                    else if (shifted < 'A')
                        shifted += 26;
                    stringBuilder.Append((char)shifted);
                }
                else
                {
                    stringBuilder.Append(letter);
                }
            }
            Text = stringBuilder.ToString().Trim();
        }
    }
}
