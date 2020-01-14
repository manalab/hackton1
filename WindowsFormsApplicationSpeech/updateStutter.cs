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
    public partial class updateStutter : Form
    {
        public updateStutter()
        {
            InitializeComponent();
        }
        //search button
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt;

            stutter s = new stutter(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            dt = s.UpdateExssisStutter();
            if (dt != null)
            {
                MessageBox.Show("is Exite");

                textBox2.Text = dt.Rows[0]["name"].ToString();
                textBox3.Text = dt.Rows[0]["email"].ToString();
                textBox4.Text = dt.Rows[0]["Username"].ToString();
                textBox5.Text = dt.Rows[0]["Password"].ToString();

                textBox1.Enabled = false;


                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("is not Exite");

                textBox1.Enabled = true;
            }

        }
        //update button
        private void button2_Click(object sender, EventArgs e)
        {
            stutter s = new stutter(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            s.updateStutter();
            MessageBox.Show("The Stutter  information is Updated");


            textBox1.Enabled = true;
            textBox1.Text = "";  //empty id text
            textBox2.Text = "";  // empty name text
            textBox3.Text = "";  //empty email text
            textBox4.Text = "";  //empty password text
            textBox5.Text = "";  //empty username text

            panel1.Visible = false;
            textBox1.Enabled = true;
        }
    }
}
