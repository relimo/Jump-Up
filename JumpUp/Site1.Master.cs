﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JumpUp
{
    public partial class Site1 : System.Web.UI.MasterPage
    {


       

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             
               //  Response.Redirect("Login.aspx");
                 Response.Redirect("WebForm1.aspx");
        }

       
        
    }
}