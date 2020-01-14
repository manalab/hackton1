using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplicationSpeech.Class;

namespace WindowsFormsApplicationSpeech
{
    public partial class deletUser : Form
    {
        public deletUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deaf C = new deaf(textBox1.Text);

            if (C.deleteDeaf())
            {
                MessageBox.Show("deaf is deleted");
                textBox1.Text = "";
                this.Close();



            }
            else
            {
                MessageBox.Show("enter ID which you want to delete", "User information");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            stutter C = new stutter(textBox1.Text);

            if (C.deleteStutter())
            {
                MessageBox.Show("stutter is deleted");
                textBox1.Text = "";
                
              


            }
            else
            {
                MessageBox.Show("valed enter ID ");
            }
        }
    }
}
