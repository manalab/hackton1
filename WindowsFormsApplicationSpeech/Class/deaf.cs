using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationSpeech.Class
{
    class deaf
    {

       
        public string id;
        public string name;
        public string email;
        public string Username;
        public string Password;

       
       public deaf(string i, string n, string p, string name, string pass)
        {
            this.id = i;
            this.name = n;
            this.email = p;
            this.Username = name;
            this.Password = pass;
        }
        public deaf(string i)
        {
            id = i;
   
        }
        public deaf(string nam, string pass)
        {
            Username = nam;
            Password = pass;
        }/*
        public void Login(string name, string pass)
        {
            Username = name;
            Password = pass;
        }*/
        public bool login()
        {
            // string sql = "select * from [Deaf] where Username='" + this.Username + "'and Password='" + this.Password + "'";
            //DataTable dt = DBFunctions.SelectFromTable(sql);
            string sql = " select * from [Deaf] where  Username = '" + this.Username + "' and Password = '" + this.Password + "'";
            
            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }
        public bool checkIfDeafExsist()
        {
            string sql = "select * from [Deaf] where ID ='" + this.id + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;

            return false;
        }
        public bool insertDeaf()
        {

            if (!checkIfDeafExsist())
            {
                string sql = " INSERT INTO [Deaf] ([id],[name],[email],[Username],[Password])";
                string sql2 = "VALUES ('" + this.id + "','" + this.name + "','" + this.email + "','" + this.Password + "','" + this.Username + "')";
                DBFunctions.ChangTable(sql + sql2);

                return true;
            }

            return false;

        }

        public bool deleteDeaf()
        {
            if (checkIfDeafExsist())
            {
                string sql = "DELETE FROM Deaf WHERE id='" + this.id + "'";
                DBFunctions.ChangTable(sql);
                return true;
            }
            else
            {
                return false;
            }
        }


        public DataTable UpdateExssisDeaf()
        {

            string sql1 = "select * from [Deaf] where id='" + this.id + "' ";
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
        public void updateDeaf()//تحديث 
        {

            string sq1 = "UPDATE  Deaf SET [name]='" + this.name + "',[email]='" + this.email + "',[Username]='" + this.Username + "',[Password]='" + this.Password + "' WHERE [id]='" + this.id + "'";
            DBFunctions.ChangTable(sq1);
        }




        public DataTable getDeafId()
        {

            string sql1 = "select id from [Deaf] where id='" + this.id + "'and Username='" + this.Username + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql1);
            return dt;
        }
        public DataTable getDeafName()
        {
            string sql1 = "select name from [Deaf] where id='" + this.id;
            DataTable dt = DBFunctions.SelectFromTable(sql1);
            return dt;
        }


        }


}


