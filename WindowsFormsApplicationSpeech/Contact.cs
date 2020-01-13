using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace WindowsFormsApplicationSpeech
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void Contact_Load(object sender, EventArgs e)
        {

        }
        // send button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("ron.s1200@gmail.com", "hghs]ma12345");
                MailMessage msg = new MailMessage();
                msg.To.Add(textBox1.Text);
                msg.From = new MailAddress(textBox1.Text);
                msg.Subject = textBox2.Text;
                msg.Body = textBox3.Text;
                client.Send(msg);
                MessageBox.Show("Successfully Send Message");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
