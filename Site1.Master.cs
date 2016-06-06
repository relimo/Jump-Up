using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JumpUp
{
    public partial class Site1 : System.Web.UI.MasterPage
    {


        //string buttonText;
        //public string ButtonText
        //{
        //    get { return Button1.Text; }
        //    set { Button1.Text = value; }
        //}

        //public string ButtonText
        //{
        //    get { return ((Button)Page.FindControl("Button1")).Text; }
        //    set { ((Button)Page.FindControl("Button1")).Text = value; }
        //}
        protected void Page_Load(object sender, EventArgs e)
        {

            string s = this.Page.Request.FilePath;
            //TODO: add list of all pages need to be "Log Out"
            if (s.Equals("/individual.aspx") || s.Equals("/ChooseLesson.aspx")|| s.Equals("/Add.aspx"))
                Button1.Text = "LogOut";
            else
                Button1.Text = "LogIn";
            //if ((string)Session["userName"] != null)
            //    Button1.Text = "LogOut";
            //else
            //    Button1.Text = "LogIn";
         //   buttonText = ((Button)Page.FindControl("Button1")).Text;  
          
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             if (Button1.Text.Equals("LogOut"))
             {
                 Button1.Text = "LogIn";
                 Session["userName"] = null;
                 Session.Abandon();
             
                 Response.Redirect("Home.aspx");
                
             }
             else
                 Response.Redirect("Login.aspx");
        }

       
        
    }
}