using System;
using System.Text;

namespace Conscript.Borderscript
{
    class BorderscriptEncoder
    {
        public string inputLabel => "Text";
        public string outputLabel => "Borderscript";

        public string Encode(string text)
        {
            var output = new StringBuilder();

            
            //Split the input on newlines
            var paragraphs = text.ToLower().Split(new string[] {"\r\n", "\n"}, StringSplitOptions.None);

            foreach (var paragraph in paragraphs)
            {
                var p = new BorderscriptParagraph(paragraph);
                output.AppendLine(p.ToString());
            };

            return output.ToString();
        }
    }
}
