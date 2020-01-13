using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;


namespace WindowsFormsApplicationSpeech
{
    public partial class speeckForm : Form
    {
        public speeckForm()
        {
            InitializeComponent();
        }
        SpeechSynthesizer reader = new SpeechSynthesizer();
        PromptBuilder pBuilder = new PromptBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText(textBox1.Text);
            reader.Speak(pBuilder);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            deafPage d = new deafPage();
            d.Closed += (s, args) => this.Close();
            d.Show();
        }
    }
}
