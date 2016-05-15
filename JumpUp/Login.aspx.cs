using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace JumpUp
{
   
    public partial class Login : System.Web.UI.Page
    {
      
        dal d = new dal();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Visible = false;
            
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            
            
                Session.Add("userName", UserName.Text);
               
       
                Response.Redirect("individual.aspx");
           
           
        }

       

       
    }
}