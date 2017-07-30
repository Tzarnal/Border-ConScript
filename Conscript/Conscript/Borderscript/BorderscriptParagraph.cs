using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conscript.Borderscript
{
    public class BorderscriptParagraph
    {
        public List<BorderscriptSentence> Sentences;

        public BorderscriptParagraph(string paragraph)
        {
            Sentences = new List<BorderscriptSentence>();
            
            //Split line on whitespace. Filter out emptystring entries.
            var sentences = paragraph.Split('.').Where(s => s != string.Empty);

            foreach (var sentence in sentences)
            {
                Sentences.Add(new BorderscriptSentence(sentence));                
            }
        }

        public override string ToString()
        {
            return ToString(80);
        }

        public string ToString(int w)
        {
            if (Sentences.Count == 0)
            {
                return "";
            }

            if (Sentences.Count == 1)
            {
                return $"╞{Sentences[0]}╡";
            }

            var rawOutput = "";
            var output = new StringBuilder();

            //Collect all sentences in one big string
            foreach (var sentence in Sentences)
            {
                rawOutput += $"╞{sentence}╡";
            }

            //Slice up in smaller char sections.
            var dividedRawOutput = ChunkString(rawOutput, w-2).ToList();

            //Generate top cap

            var topLine = PadLine(dividedRawOutput[0],w);
            var topCap = TopCapLine(topLine);

            output.AppendLine(topCap);
            output.AppendLine(topLine);

            //Repadd back to orignal size.
            for (var i = 1; i < dividedRawOutput.Count - 1; i++)
            {
                output.AppendLine(PadLine(dividedRawOutput[i],w));
            }

            var bottomLine = PadLine(dividedRawOutput[dividedRawOutput.Count - 1],w);
            var bottomCap = BottomCapLine(bottomLine);

            if (bottomLine != topLine)
            {
                output.AppendLine(bottomLine);
            }            
            output.AppendLine(bottomCap);

            return output.ToString();
        }

        private static IEnumerable<string> ChunkString(string input, int chunkSize)
        {
            for (int i = 0; i < input.Length; i += chunkSize)
            {
                yield return input.Substring(i, Math.Min(chunkSize, input.Length - i));
            }                
        }

        private string TopCapLine(string line)
        {
            var topCap = "┌";

            for (var i = 1; i < line.Length - 1; i++)
            {
                if (line[i] == '├' || line[i] == '╪' || line[i] == '┤')
                {
                    topCap += '┬';
                }
                else
                {
                    topCap += '─';
                }                
            }

            topCap += "┐";

            return topCap;
        }

        private string BottomCapLine(string line)
        {
            var topCap = "└";

            for (var i = 1; i < line.Length - 1; i++)
            {
                if (line[i] == '├' || line[i] == '╪' || line[i] == '┤')
                {
                    topCap += '┴';
                }
                else
                {
                    topCap += '─';
                }
            }

            topCap += "┘";

            return topCap;
        }

        private string PadLine(string line,int w = 80 )
        {
            var difference = w - (line.Length + 2);
            
            //oversized
            if (difference < 0)
            {
                return "BROKEN";
            }

            //fits exactly
            if (difference == 0)
            {
                if (line[0] == '╞')
                {
                    return $"│{line}╡";
                }

                return $"╞{line}╡";                
            }
            
            if (difference == 1)
            {
                if (line[0] == '╞')
                {
                    return $"│{line}╡";
                }

                return $"╞{line}╡";
            }

            line = $"╞{line}├";

            line = line.PadRight(w -1, '─');

            return line + "┤";
        }
    }
}
