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
    public partial class deleteDeaf : Form
    {
        public deleteDeaf()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)

        {
            deaf C = new deaf(textBox1.Text);
          
            if (C.deleteDeaf())
            {
                MessageBox.Show("You been delete!");
                textBox1.Text = "";
                this.Hide();
                FrmLogin dd = new FrmLogin();
                dd.Closed += (s, args) => this.Close();
                dd.Show();


            }
            else
            {
                MessageBox.Show("enter ID which you want to delete", "User information");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
