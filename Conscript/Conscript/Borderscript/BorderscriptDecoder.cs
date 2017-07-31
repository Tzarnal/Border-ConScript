using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;


namespace Conscript.Borderscript
{
    class BorderscriptDecoder
    {
        private string[] _wordList;

        public BorderscriptDecoder()
        {
            _wordList = LoadWordList(@"Borderscript\Wordlist 1000.txt");
        }

        public string Decode(string input)
        {
            var output = new StringBuilder();

            var strippedInput = "";

            var matches = Regex.Matches(TrimLinesDecorations(input), @"[╞═╬╩╦╪╡]+");

            foreach (Match match in matches)
            {
                strippedInput+=match.ToString() + Environment.NewLine;
            }

            var paragraphs = strippedInput.Split(new[] {"╡\r\n", "╡\n"}, StringSplitOptions.None);

            foreach (var paragraph in paragraphs)
            {
                output.AppendLine(DecodePargraph(paragraph));
                output.AppendLine();
            }

            return output.ToString().Trim();
            //return strippedInput;
        }

        private string DecodePargraph(string input)
        {            
            var output = "";

            input = input.Replace("\r\n", "");
            input = input.Replace("\n", "");

            var words = input.Split('╪', '╞');

            foreach (var word in words)
            {
                if (string.IsNullOrWhiteSpace(word))
                {
                    continue;
                }

                output += DecodeWord(word) + " ";
            }

            output = output.Trim();

            if (!string.IsNullOrWhiteSpace(output))
            {
                output += ".";
            }

            return output.Trim();
        }

        private string DecodeWord(string input)
        {
            var output = "";

            if (string.IsNullOrWhiteSpace(input))
            {
                return "";
            }

            var isLAstWordInSentence = input[input.Length - 1] == '╡';
            input = input.TrimEnd('╡');

            input = input.Replace('═', '0');
            input = input.Replace("╩", "1");
            input = input.Replace("╦", "11");
            input = input.Replace("╬", "111");

            input = ReverseString(input);

            var inputInt = Convert.ToInt32(input, 2);
            
            output = _wordList[inputInt-1];
            
            if (isLAstWordInSentence)
            {
                output += ".";
            }

            return output;
        }

        private static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        private string TrimLinesDecorations(string input)
        {
            var output = "";

            var lines = input.Split(new[] {"\r\n", "\n"}, StringSplitOptions.None);
            
            foreach (var line in lines)
            {
                var outputLine = line;
                if (line.Length == 80)
                {
                    outputLine = line.Trim('╞', '╡', '│');                    
                }

                output += outputLine + Environment.NewLine;
            }

            return output;
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
    }

}
