using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationSpeech.Class
{
    class stutter
    {

        public
          string id;
        string name;
        string email;
        string Username;
        string Password;

        stutter()
        {
            id = "0";
            name = "0";
            email = "0";
            Username = "0";
            Password = "0";
        }
        public stutter(string i, string n, string p, string name, string pass)
        {
            this.id = i;
            this.name = n;
            this.email = p;
            this.Username = name;
            this.Password = pass;
        }
        void Login(string name, string pass)
        {
            Username = name;
            Password = pass;
        }
        public stutter(string i)
        {
            this.id = i;

        }
        public stutter(string us,string p)
        {
            this.Username = us;
            this.Password = p;

        }
        public bool login()
        {

            string sql = " select * from [Stutter] where  Username = '" + this.Username + "' and Password = '" + this.Password + "'";

            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public bool checkIfStutterExsist()
        {
            string sql = "select * from [Stutter] where ID ='" + this.id + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;

            return false;
        }
        public bool insertStudent()
        {

            if (!checkIfStutterExsist())
            {
                string sql = " INSERT INTO [Stutter] ([id],[name],[email],[Username],[Password])";
                string sql2 = "VALUES ('" + this.id + "','" + this.name + "','" + this.email + "','" + this.Password + "','" + this.Username + "')";
                DBFunctions.ChangTable(sql + sql2);

                return true;
            }

            return false;

        }
        public DataTable getStutterId()
        {

            string sql1 = "select id from [Stutter] where id='" + this.id + "'and Username='" + this.Username + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql1);
            return dt;
        }
        public void updateStutter()//تحديث 
        {

            string sq1 = "UPDATE  Stutter SET [id]='" + this.id + "',[name]='" + this.name + "',[email]='" + this.email + "' WHERE [id]='" + this.id + "'";
            DBFunctions.ChangTable(sq1);
        }
        public bool deleteStutter()
        {
            if (checkIfStutterExsist())
            {
                string sql = "DELETE FROM Stutter WHERE id='" + this.id + "'";
                DBFunctions.ChangTable(sql);
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable UpdateExssisStutter()
        {

            string sql1 = "select * from [Stutter] where id='" + this.id + "' ";
            DataTable dt = DBFunctions.SelectFromTable(sql1);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }

            else
            {
                return null;
            }
        }
    }
}





