using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class UserManage
    {


        public Model.UserInfo userlogin(string name, string password)
        {
            DAL.UserDAO ud = new DAL.UserDAO();
            Model.UserInfo ui=ud.selectuser(name,password);

            if (ui != null)
            {
                return ui;
            }
            else
            {
                throw new Exception("login failed");
            }

        }

    }
}
