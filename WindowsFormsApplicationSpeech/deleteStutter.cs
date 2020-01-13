using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using WindowsFormsApplicationSpeech.Class;

namespace WindowsFormsApplicationSpeech
{
    public partial class deleteStutter : Form
    {
        public deleteStutter()
        {
            InitializeComponent();
        }

        //delete button
        private void button1_Click(object sender, EventArgs e)
        {
            stutter C = new stutter(textBox1.Text);

            if (C.deleteStutter())
            {
                MessageBox.Show("stutter is deleted");
                textBox1.Text = "";
                this.Hide();
                FrmLogin dd = new FrmLogin();
                dd.Closed += (s, args) => this.Close();
                dd.Show();


            }
            else
            {
                MessageBox.Show("valed enter ID ");
            }
        }
    }
}

