using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void buttonlogin(object sender, EventArgs e)
    {
        try
        {
            BLL.UserManage um = new BLL.UserManage();
            Model.UserInfo ui = um.userlogin(Text1.Value, Text2.Value) ;


            Session["name"] = ui.name ;
            Response.Write("<script>alert('login ok');location.href='main.aspx';</script>");
        }
        catch (Exception ex)
        {

            Response.Write("<script>alert('"+ex.Message+"');</script>");
        }


    }



}