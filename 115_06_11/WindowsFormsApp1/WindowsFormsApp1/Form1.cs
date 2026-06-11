using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Dictionary<char, string> _morseMap = new Dictionary<char, string>()
        {
            {'A', ".-"},{'B', "-..."},{'C', "-.-."},{'D', "-.."},{'E', "."},
            {'F', "..-."},{'G', "--."},{'H', "...."},{'I', ".."},{'J', ".---"},
            {'K', "-.-"},{'L', ".-.."},{'M', "--"},{'N', "-."},{'O', "---"},
            {'P', ".--."},{'Q', "--.-"},{'R', ".-."},{'S', "..."},{'T', "-"},
            {'U', "..-"},{'V', "...-"},{'W', ".--"},{'X', "-..-"},{'Y', "-.--"},
            {'Z', "--.."},
            {'0', "-----"},{'1', ".----"},{'2', "..---"},{'3', "...--"},{'4', "....-"},
            {'5', "....."},{'6', "-...."},{'7', "--..."},{'8', "---.."},{'9', "----."},
            {' ', "/"}
        };

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string input = textBoxInput.Text ?? string.Empty;
            var morseBuilder = new System.Text.StringBuilder();
            foreach (char ch in input)
            {
                char up = char.ToUpperInvariant(ch);
                if (_morseMap.TryGetValue(up, out string code))
                {
                    morseBuilder.Append(code + " ");
                    listBox1.Items.Add($"{ch} : {code}");
                }
                else
                {
                    morseBuilder.Append("? ");
                    listBox1.Items.Add($"{ch} : (無對應)");
                }
            }

            textBoxMorse.Text = morseBuilder.ToString().TrimEnd();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            textBoxMorse.Clear();
            listBox1.Items.Clear();
        }
    }
}
