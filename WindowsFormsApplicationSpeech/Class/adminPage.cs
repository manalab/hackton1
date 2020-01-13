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
    public partial class adminPage : Form
    {
        public adminPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register ss = new Register();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register dd = new Register();
            dd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateUsers dd = new updateUsers();
            dd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            updateUsers ss = new updateUsers();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            deletUser ss = new deletUser();
            ss.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            deleteStutter ss = new deleteStutter();
            ss.Show();
        }
        //report button for deaf
        private void button8_Click(object sender, EventArgs e)
        {/*
            this.Hide();
            reportDeaf re = new reportDeaf();
            re.Show();*/
        }
        // contact button with deaf
        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact con = new Contact();
            con.Show();
        }
        // contact button with stutter
        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact con = new Contact();
            con.Show();
        }
    }
}
