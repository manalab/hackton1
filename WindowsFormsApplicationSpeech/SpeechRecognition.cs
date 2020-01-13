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
    public partial class SpeechRecognition : Form
    {
        public SpeechRecognition()
        {
            InitializeComponent();
        }
        // recognition speech button
        private void button1_Click(object sender, EventArgs e)
        {

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
