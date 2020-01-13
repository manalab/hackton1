using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace WindowsFormsApplicationSpeech
{
    public partial class spaechText : Form
    {
        public spaechText()
        {
            InitializeComponent();
        }

        private void spaechText_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SpeechSynthesizer ss = new SpeechSynthesizer();
            //ss.Volume = trackBar1.Value;
            //ss.Speak(textBox1.Text);
            SpeechRecognitionEngine s = new SpeechRecognitionEngine();
            Grammar words = new DictationGrammar();
            s.LoadGrammar(words);

            try
            {
                s.SetInputToDefaultAudioDevice();
                RecognitionResult result = s.Recognize();
                textBox1.Text = result.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.UnloadAllGrammars();
            }
        }
    }
}
