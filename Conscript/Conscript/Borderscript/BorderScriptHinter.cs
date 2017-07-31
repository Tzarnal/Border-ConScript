using System.IO;
using System.Linq;

namespace Conscript.Borderscript
{
    class BorderScriptHinter
    {
        private string[] _wordList;

        public BorderScriptHinter()
        {
            _wordList = LoadWordList(@"Borderscript\Wordlist 1000.txt");
        }

        public bool IsValid(string word)
        {
            return _wordList.Contains(word);
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
