using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplicationSpeech.Class
{
  public  class admin
    {
      public  string id;
      public  string name;
      public  string email;
      public  string Username;
      public  string Password;
        
        public admin()
        {
        }
      public  admin(string i, string n, string p,string name, string pass)
        {
           id = i;
           name = n;
           email = p;
           Username = name;
           Password = pass;
        }
     public admin(string name, string pass)
        {
            Username = name;
            Password = pass;
        }
        public bool login()
        {
            // string sql = "select * from [Deaf] where Username='" + this.Username + "'and Password='" + this.Password + "'";
            //DataTable dt = DBFunctions.SelectFromTable(sql);
            string sql = " select * from [Admin] where  Username = '" + this.Username + "' and Password = '" + this.Password + "'";

            DataTable dt = DBFunctions.SelectFromTable(sql);
            if (dt.Rows.Count > 0)
                return true;
            return false;
        }

        public DataTable getAdminId()
        {

            string sql1 = "select id from [Admin] where id='" + this.id + "'and Username='" + this.Username + "'";
            DataTable dt = DBFunctions.SelectFromTable(sql1);
            return dt;
        }

    }
}
