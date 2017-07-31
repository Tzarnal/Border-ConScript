using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Conscript.Borderscript;

namespace Conscript
{
    public partial class MainForm : Form
    {
        private BorderscriptEncoder _encoder;
        private BorderScriptHinter _hinter;

        private int _previousInputTextLengt = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _encoder = new BorderscriptEncoder();
            _hinter = new BorderScriptHinter();
        }

        private void InputTextChanged(object sender, EventArgs e)
        {            
            outputTextBox.Text = _encoder.Encode(inputTextBox.Text);
            HighLightText();
        }

        private void HighLightText()
        {
            if (inputTextBox.TextLength - _previousInputTextLengt > 1)
            {
                HighLightAllText();
            }
            else
            {
                HighLightTextLine();
            }

            _previousInputTextLengt = inputTextBox.TextLength;
        }


        private void HighLightTextLine(int? line = null)
        {
            var currentLine = line == null 
                ? inputTextBox.GetFirstCharIndexOfCurrentLine() 
                : inputTextBox.GetFirstCharIndexFromLine(line.Value);

            if (line == null)
            {

                line = inputTextBox.GetLineFromCharIndex(currentLine);
            }

            if (inputTextBox.Lines.Length <= line.Value)
            {
                return;
            }

            //Prep
            inputTextBox.SuspendLayout();
            inputTextBox.Suspend();
            var originalCursorLocation = inputTextBox.SelectionStart;
            
            //Color whole line box black
            inputTextBox.Select(currentLine, inputTextBox.Lines[line.Value].Length);
            inputTextBox.SelectionColor = Color.Black;

            var words = Regex.Matches(inputTextBox.Text, @"\w+");
            foreach (Match wordMatch in words)
            {
                var word = wordMatch.ToString();
                if (!_hinter.IsValid(word))
                {
                    if (!string.IsNullOrWhiteSpace(word.ToLower()))
                    {
                        ColorWordInInput(word, currentLine);
                    }

                }
            }

            //Return to defaults
            inputTextBox.SelectionStart = originalCursorLocation;
            inputTextBox.SelectionLength = 0;
            inputTextBox.SelectionColor = Color.Black;

            inputTextBox.Resume();
            inputTextBox.ResumeLayout();
        }

        private void HighLightAllText()
        {
            int i = 0;

            foreach (var line in inputTextBox.Lines)
            {
                HighLightTextLine(i);
                i++;
            }
        }

        private void ColorWordInInput(string word,int startIndex = 0)
        {
            var wordIndex = inputTextBox.Find(word, startIndex, RichTextBoxFinds.WholeWord);
            var wordLength = word.Length;

            if (wordIndex == -1)
                return;

            inputTextBox.Select(wordIndex,wordLength);
            inputTextBox.SelectionColor = Color.Red;                        
        }


    }
}
