using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApplicationSpeech
{
    public partial class contactUs : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public contactUs()
        {
            InitializeComponent();
        }
       
        
        //send button
        private void button1_Click(object sender, EventArgs e)
        {
            string to, from, pass, mail;
            to = (textBox1.Text).ToString();
            from = (textBox2.Text).ToString();
            mail = (textBox3.Text).ToString();
            pass = (textBox4.Text).ToString();
            MailMessage message = new MailMessage();
            message.To.Add("maramalasad9@gmail.com");
            message.From = new MailAddress(from);
            message.Body = mail;
            message.Subject = "Testing mail";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Email send successfully", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact con = new Contact();
            con.Closed += (s, args) => this.Close();
            con.Show();

        }
    }
}
