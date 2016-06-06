using JumpUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class MyLes : System.Web.UI.Page
    {

        Bl b = new Bl();

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["userName"] == null)
                Response.Redirect("Home.aspx");


           string []arr =b.getAllLessons();
           string[] arrDates = b.getAllDates();
            HtmlGenericControl li;
            HtmlGenericControl anchor;
            for (int i = 0; i < arr.Length-1; i++)
			{
			 li=  new HtmlGenericControl("li");
             u1.Controls.Add(li);
            // li.InnerText = "aaa" + i;
             anchor = new HtmlGenericControl("a");
             anchor.Attributes.Add("href", "Add.aspx?name="+arr[i]+"&name_or_date=n");
             anchor.InnerText = arr[i];
             li.Controls.Add(anchor);
           


			}
            for (int i = 0; i < arrDates.Length - 1; i++)
            {
                li = new HtmlGenericControl("li");
                u2.Controls.Add(li);
                anchor = new HtmlGenericControl("a");
                anchor.Attributes.Add("href", "Add.aspx?date=" + arrDates[i] + "&name_or_date=d");
                anchor.InnerText = arrDates[i];
                li.Controls.Add(anchor);



            }




        }
    }
}