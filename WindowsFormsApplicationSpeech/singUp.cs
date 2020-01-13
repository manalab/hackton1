using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplicationSpeech.Class;

namespace WindowsFormsApplicationSpeech
{
    public partial class singUp : Form
    {
        public singUp()
        {
            InitializeComponent();
        }

        // buttun sing up form  deaf
        private void button2_Click(object sender, EventArgs e)
        {
            deaf d = new deaf(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            if (d.insertDeaf())
            {
                this.Hide();
                deafPage dd = new deafPage();
                dd.Closed += (s, args) => this.Close();
                dd.Show();

            }
            else
            {
                MessageBox.Show(" the Deaf is exsist !!!!!!");
            }



        }

        // buttun sing up form  stutter
        private void button3_Click(object sender, EventArgs e)
        {
            stutter s = new stutter(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            if (s.insertStudent())
            {
                this.Hide();
                stutterPage ss = new stutterPage();
                ss.Closed += (c, args) => this.Close();
                ss.Show();

            }
            else
            {
               MessageBox.Show( " the Stutter is exsist !!!!!!");
            }

        }

        private void singUp_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
        }
    }
}
