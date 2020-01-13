using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationSpeech
{
    public partial class stutterer : Form
    {
        public stutterer()
        {
            InitializeComponent();
        }
        //deleat stutter
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteStutter ss = new deleteStutter();
            ss.Closed += (s, args) => this.Close();
            ss.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            speeckForm speak = new speeckForm();
            speak.Closed += (s, args) => this.Close();
            speak.Show();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateStutter ss = new updateStutter();
            ss.Closed += (s, args) => this.Close();
            ss.Show();
        }
        // repot button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            reportStutter report = new reportStutter();
            report.Closed += (s, args) => this.Close();
            report.Show();

        }
        // conversation  button
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            talkRecognition talk = new talkRecognition();
            talk.Closed += (s, args) => this.Close();
            talk.Show();
        }
        // Speech Recognition button
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpeechRecognition recognition = new SpeechRecognition();
            recognition.Closed += (s, args) => this.Close();
            recognition.Show();

        }
        // contact button
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            contactUs us = new contactUs();
            us.Closed += (s, args) => this.Close();
            us.Show();
        }
    }
}
