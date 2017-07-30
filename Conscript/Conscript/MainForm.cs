using System;
using System.Windows.Forms;
using Conscript.Borderscript;

namespace Conscript
{
    public partial class MainForm : Form
    {
        private BorderscriptEncoder _encoder;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _encoder = new BorderscriptEncoder();
        }

        private void InputTextChanged(object sender, EventArgs e)
        {
            outputTextBox.Text = _encoder.Encode(inputTextBox.Text);
        }
    }
}
