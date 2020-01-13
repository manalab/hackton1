using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationSpeech.Class
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deaf d = new deaf(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            if (d.insertDeaf())
            {

                MessageBox.Show(" Deaf been add");

            }
            else
            {
                MessageBox.Show(" the Deaf is exsist !!!!!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            stutter s = new stutter(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            if (s.insertStudent())
            {
                this.Hide();
                stutterPage ss = new stutterPage();
                ss.Closed += (f, args) => this.Close();
                ss.Show();

            }
            else
            {
                MessageBox.Show(" the Stutter is exsist !!!!!!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminPage a = new adminPage();
            a.Closed += (s, args) => this.Close();
            a.Show();
        }
    }
}
