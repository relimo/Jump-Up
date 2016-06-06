using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JumpUp
{
    public partial class Registera : System.Web.UI.Page
    {
        Bl b = new Bl();
        protected void Page_Load(object sender, EventArgs e)
        {

            err.Visible = false;
            int day = 0;
            for (int i = 0; i < 31; i++)
            {
                day++;
                DropDownList1.Items.Add(day.ToString());
            }
            int month = 0;
            for (int i = 0; i < 12; i++)
            {
                month++;
                DropDownList2.Items.Add(month.ToString());
            }
            int year = 1940;
            for (int i = 0; i < 70; i++)
            {
                year++;
                DropDownList3.Items.Add(year.ToString());
            }
            DropDownList3.Text = "1990";
        }

        protected void CreateUserButton_Click(object sender, EventArgs e)
        {
            err.Visible = false;
            string date = Request.Form[DropDownList1.UniqueID] + "/" + Request.Form[DropDownList2.UniqueID] + "/" + Request.Form[DropDownList3.UniqueID];
            string result = b.addClient(UserName.Text, Password.Text, TextBox1.Text, TextBox2.Text, Email.Text, date);
            if (result.Equals("error"))
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('There ia an error with opening the DB');</script>");
            // Label5.Text="There ia an error with opening the DB";
            else if (result.Equals("false"))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('There is already such a user name, choose a new one');</script>");
                //err.Visible = true;
                //err.Text = "There is already such a user name, choose a new one!";
            }
            else
            {
                // Label5.Text = "The registration was succeeded! "; 
                Session.Add("userName", UserName.Text);
                Response.Redirect("individual.aspx");

            }
        }

        protected void UserName_TextChanged(object sender, EventArgs e)
        {
            err.Visible = false;
        }
    }
}