using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.IO;

namespace WindowsFormsApplicationSpeech
{
    public partial class talkRecognition : Form
    {
        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        SpeechSynthesizer Sarah = new SpeechSynthesizer();
        SpeechRecognitionEngine startlistening = new SpeechRecognitionEngine();// to give commands
        Random rnd = new Random();
        int RecTimeOut = 0;
        DateTime timeNow = DateTime.Now;

        public talkRecognition()
        {
            InitializeComponent();
        }

        private void talkRecognition_Load(object sender, EventArgs e)
        {
            _recognizer.SetInputToDefaultAudioDevice();
            _recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands.txt")))));
            _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_speechRecognized);
            _recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(recognizer_speechRecognized);
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);

            startlistening.SetInputToDefaultAudioDevice();
            startlistening.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands.txt")))));
            startlistening.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(startlistening_speechRecognized);





        }
        private void Default_speechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            int ranNum;
            string speech = e.Result.Text;
            if (speech == "Hello")
            {
                Sarah.SpeakAsync("Hello, i am here");
            }
            if (speech == "How are you")
            {
                Sarah.SpeakAsync("i am working normally");
            }
            if (speech == "What time is it")
            {
                Sarah.SpeakAsync(DateTime.Now.ToString("h mm tt"));
            }
            if(speech=="Stop talking")
            {
                Sarah.SpeakAsyncCancelAll();
                ranNum = rnd.Next(1);
                if (ranNum == 1)
                {
                    Sarah.SpeakAsync("yes sir");
                }
                if (ranNum == 2)
                {
                    Sarah.SpeakAsync("i am sorry i will be quiet");
                }
            }
            if(speech=="Stop listening")
            {
                Sarah.SpeakAsync("if you need me just ask");
                _recognizer.RecognizeAsyncCancel();
                startlistening.RecognizeAsync(RecognizeMode.Multiple);
            }
            if(speech=="Show List")
            {
                string[] commands = (File.ReadAllLines(@"DefaultCommands.txt"));
                listCommands.Items.Clear();
                listCommands.SelectionMode = SelectionMode.None;
                listCommands.Visible = true;
                foreach(string command in commands)
                {
                    listCommands.Items.Add(command);
                }

            }
            if(speech=="Close Commands")
            {
                listCommands.Visible = false;
            }
        }

        private void recognizer_speechRecognized(object sender, SpeechDetectedEventArgs e)
        {
            RecTimeOut = 0;
        }

    
        private void startlistening_speechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;
            if(speech=="Wake up")
            {
                startlistening.RecognizeAsyncCancel();
                Sarah.SpeakAsync("Yes, I am here");
                _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }
        }

        private void TmrSpeaking_Tick(object sender, EventArgs e)
        {
            if (RecTimeOut == 10)
            {
                _recognizer.RecognizeAsyncCancel();
            }
            else if(RecTimeOut == 11)
            {
                TmrSpeaking.Stop();
                startlistening.RecognizeAsync(RecognizeMode.Multiple);
                RecTimeOut = 0;
            }
        }

        private void listCommands_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
