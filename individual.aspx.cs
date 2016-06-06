using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JumpUp
{
    public partial class individual : System.Web.UI.Page
    {

        dal da = new dal();
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
            ///put the first name of the user in the label
            Label1.Text = da.get_client_name_according_to_user_name((string)Session["userName"]);
            
            if (!IsPostBack)
            {
              
              GridView1.DataSource = da.getDetailsForUser((string)Session["userName"]);
           
              GridView1.DataBind();
            }



        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //string autid = GridView1.DataKeys[e.RowIndex].Value.ToString();
            if (this.GridView1.Rows.Count > 0)
            {
                GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
                
               
                string dt1 = GridView1.Rows[e.RowIndex].Cells[2].Text;
                int room = Convert.ToInt16( GridView1.Rows[e.RowIndex].Cells[3].Text);


                string user = (string)Session["userName"];
              da.delete_lesson(user, dt1, room);
              GridView1.DataSource = da.getDetailsForUser(user);
                GridView1.DataBind();

            }


           

        }


    }
}