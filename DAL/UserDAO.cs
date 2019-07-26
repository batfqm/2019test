using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDAO
    {

        DB mydb = new DB();

        public Model.UserInfo selectuser(string name,string password)
        {
            Model.UserInfo ui = null;

            mydb.sqlcom(mydb.openconn());

            mydb.com.CommandText = "select * from users where name=@name and password=@password";
            mydb.com.Parameters.Add(new SqlParameter("@name", name));
            mydb.com.Parameters.Add(new SqlParameter("@password", password));

            if (mydb.sqlread(mydb.com).Read())
            {
                ui = new Model.UserInfo();

                ui.id = mydb.read.GetInt32(0);
                ui.name = mydb.read.GetString(1);
                ui.password = mydb.read.GetString(2);
                ui.role = mydb.read.GetString(3);

                

            }


            return ui;


        }



    }
}
