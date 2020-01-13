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
    public partial class deafPage : Form
    {
        public deafPage()
        {
            InitializeComponent();
        }
        // speack button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            speeckForm speak = new speeckForm();
            speak.Closed += (s, args) => this.Close();
            speak.Show();
        }
        //update button
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Hide();
            updeatDeaf up = new updeatDeaf();
            up.Closed += (s, args) => this.Close();
            up.Show();
        }
        //image button
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteDeaf dd = new deleteDeaf();
            dd.Closed += (s, args) => this.Close();
            dd.Show();
        }
        //contact button
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            contactUs c = new contactUs();
            c.Closed += (s, args) => this.Close();
            c.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            addImige add = new addImige();
            add.Closed += (s, args) => this.Close();
            add.Show();
        }
        //report button
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
