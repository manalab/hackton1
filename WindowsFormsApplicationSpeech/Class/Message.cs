using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplicationSpeech.Class
{
    class Message
    {
        public string name;
        public string message;


        public Message(string n, string m)
        {
            this.name = n;
            this.name = m;
        }
        public bool checkIfMessageExsist()
        {
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Desktop\WindowsFormsApplicationSpeech\WindowsFormsApplicationSpeech\DatabaseMessage.mdf;Integrated Security=True");
            string search = "select * from [Message] where name ='" + this.name + "'";
            SqlDataAdapter sda = new SqlDataAdapter(search, sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public static void ChangTable(string sqlString)
            SqlConnection conObj = GenerateConnection();
            SqlCommand cmd = new SqlCommand(sqlString, conObj);
            cmd.ExecuteNonQuery();
            conObj.Close();

        }
        public void updateDeaf()
        {

            string sq1 = "UPDATE Message SET [name]='" + this.name + "'";
            DBFunctions.ChangTable(sq1);
        }
    }
}
