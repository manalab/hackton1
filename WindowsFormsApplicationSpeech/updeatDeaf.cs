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

using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplicationSpeech
{
    public partial class updeatDeaf : Form
    {
        
        
        public updeatDeaf()
        {
            InitializeComponent();
        }

        private void updeatDeaf_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        // update button
        private void button3_Click(object sender, EventArgs e)
        {
            deaf d = new deaf(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            d.updateDeaf();
            MessageBox.Show("The Deaf  information is Updated");
            
          
            textBox1.Enabled = true;
            textBox1.Text = "";  //empty id text
            textBox2.Text = "";  // empty name text
            textBox3.Text = "";  //empty email text
            textBox4.Text = "";  //empty password text
            textBox5.Text = "";  //empty username text

            panel1.Visible = false;
            textBox1.Enabled = true;


        }
       
        //log out button
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\khawla\Desktop\WindowsFormsApplicationSpeech\WindowsFormsApplicationSpeech\DatabaseUsers.mdf;Integrated Security=false");
            con.Open();
            // MessageBox.Show(" bd....");
            // Password = '" + (textBox5.Text)+ "'

            string sql = "SELECT * FROM Deaf WHERE id='" + (textBox1.Text) + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();

       




        }
        //Search button
        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dt;

            deaf d= new deaf(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            //deaf d = new deaf(textBox1.Text);
 
             dt = d.UpdateExssisDeaf();
            //DataTable s = d.getDeafName();
            if (dt != null)
            {
                MessageBox.Show("is Exite");

              textBox2.Text = dt.Rows[0]["name"].ToString();
                //textBox2.Text = s.ToString();
                //textBox2.Text = dt.Rows[0]["name"].ToString();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
