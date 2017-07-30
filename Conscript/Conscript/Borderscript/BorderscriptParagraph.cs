using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
           var output = new StringBuilder();

            foreach (var sentence in Sentences)
            {
                output.Append($"╞{sentence}╡");
            }

            return output.ToString();
        }
    }
}
