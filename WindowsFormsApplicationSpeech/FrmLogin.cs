using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplicationSpeech.Class;
using System.Drawing;

namespace WindowsFormsApplicationSpeech
{
    public partial class FrmLogin : Form 
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //only deaf can access, deaf button(log in deaf)
        private void button2_Click(object sender, EventArgs e)
        {
            deaf C = new deaf(textBox1.Text, textBox2.Text);
            DataTable d = C.getDeafId();
           
            if (C.login())
            {
           
                
               // MessageBox.Show("LOGIN Done");
                this.Hide();
                deafPage ss = new deafPage();
                ss.Closed += (s, args) => this.Close();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please check you Username and Password");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Exit button
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // only admin can access, admin button(log in Admin)
        private void button1_Click(object sender, EventArgs e)
        {
            admin C = new admin(textBox1.Text, textBox2.Text);
            DataTable d = C.getAdminId();

            if (C.login())
            {


               // MessageBox.Show("LOGIN Done");
                this.Hide();
                adminPage a = new adminPage();
                a.Closed += (s, args) => this.Close();
                a.Show();
            }
            else
            {
                MessageBox.Show("Please check you Username and Password");
            }
        }
        // only Stutter can access, Stutter button(log in Stutter)
        private void button3_Click(object sender, EventArgs e)
        {
            stutter s = new stutter(textBox1.Text, textBox2.Text);
            DataTable d = s.getStutterId();

            if (s.login())
            {


                //MessageBox.Show("LOGIN Done");
                this.Hide();
                stutterer ss = new stutterer();
                ss.Closed += (f, args) => this.Close();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please check you Username and Password");
            }
          
               
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            singUp singup = new singUp();
            singup.Closed += (s, args) => this.Close();
            singup.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            updeatDeaf up = new updeatDeaf();
            up.Closed += (s, args) => this.Close();
            up.Show();

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
           // panel1.BackColor = Color.FromArgb(25, Color.Black);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          //  panel2.BackColor = Color.FromArgb(25, Color.Green);
        }
    }
}