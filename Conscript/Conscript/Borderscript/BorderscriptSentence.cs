using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Conscript.Borderscript
{
    public class BorderscriptSentence
    {
        private string[] _wordList;

        public List<string> Words;

        public BorderscriptSentence(string sentence)
        {
            _wordList = LoadWordList(@"Borderscript\Wordlist 1000.txt");
            Words = new List<string>();

            //Split line on whitespace. Filter out emptystring entries.
            var words = sentence.Split().Where(w => w != String.Empty);

            foreach (var word in words)
            {
                if (_wordList.Contains(word))
                {
                    Words.Add(EncodeWord(word));
                }
            }
        }

        private string EncodeWord(string word)
        {
            //Find the index, add 1 since the array is 0 indexed.
            int i = Array.IndexOf(_wordList, word) + 1;

            //Convert to a binary representation, but as a string.
            var iBinary = Convert.ToString(i, 2);

            //Reverse the string
            var iSymbol = ReverseString(iBinary);

            //Convert 0's to ═
            iSymbol = iSymbol.Replace('0', '═');

            //Convert 111's to ╬
            iSymbol = iSymbol.Replace("111", "╬");

            //Convert 11's to ╦
            iSymbol = iSymbol.Replace("11", "╦");

            //Convert 1's to ╩
            iSymbol = iSymbol.Replace('1', '╩');

            return iSymbol;
        }

        private static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        private string[] LoadWordList(string filePath)
        {
            if (File.Exists(filePath))
            {
                var wordFile = File.ReadAllLines(filePath);
                return wordFile;
            }

            throw new FileNotFoundException();
        }

        public override string ToString()
        {
            return string.Join("╪", Words);
        }
    }
}
