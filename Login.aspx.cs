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
        Bl b = new Bl();
        dal d = new dal();
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    Label2.Visible = false;
            
        //}

        protected void loginButton_Click(object sender, EventArgs e)
        {

            bool result = b.checkPassword(UserName.Text, Password.Text);
            if (!result)//אין תיאום 
            {
                err.Visible = true;
                err.Text = "either the user name or the password (or both of them..) is not correct";
            }
            else
            {
                Session.Add("userName", UserName.Text);
                Session.Add("password", Password.Text);
                // TODO: //welcome user name
                //Response.Redirect("YourSite.aspx");
                //    string s = ((Button)Master.FindControl("Button1")).Text;
                //   this.Master.ButtonText = "logOut";
                // ((Button)Master.FindControl("Button1")).Text = "logOut";
                Response.Redirect("individual.aspx");

            }
        }
        
        //restoring password
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Visible = false;
            
            if(UserName.Text == "" )
            {
                Label2.Visible = true;
                Label2.Text = "Please enter your name";
                return;
                
            }
            if (d.UserName_exists(UserName.Text) == "")
            {
                Label2.Visible = true;
                Label2.Text = "User name does not exist";
                return;
            }

            if (d.UserName_exists(UserName.Text) != "")
            {

                //if (String.IsNullOrEmpty(email))
                //    return;
                //try
                //{
                //    MailMessage mail = new MailMessage();
                //    //mail.To.Add(email);
                //    mail.To.Add("chavalevi@gmail.com");
                //    mail.From = new MailAddress("justJumpApp@gmail.com");
                //    mail.Subject = "restore password";

                //    mail.Body = "hi";

                //    mail.IsBodyHtml = true;
                //    SmtpClient smtp = new SmtpClient();
                //    smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                //    smtp.Credentials = new System.Net.NetworkCredential
                //         ("justJumpApp@gmail.com", "pw"); // ***use valid credentials***
                //    smtp.Port = 587;

                //    //Or your Smtp Email ID and Password
                //    smtp.EnableSsl = true;
                //    smtp.Send(mail);
                //}
                //catch (Exception ex)
                //{
                //    Label2.Visible = true;
                //    Label2.Text = "Exception in sendEmail:" + ex.Message;
                //}
                
                //SmtpClient smtpClient = new SmtpClient("mail.MyWebsiteDomainName.com", 25);

                //smtpClient.Credentials = new System.Net.NetworkCredential("info@MyWebsiteDomainName.com", "myIDPassword");
                //smtpClient.UseDefaultCredentials = true;
                //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                //smtpClient.EnableSsl = true;
                //MailMessage mail = new MailMessage();

                ////Setting From , To and CC
                //mail.From = new MailAddress("justJumpApp@gmail.com", "MyWeb Site");
                //mail.To.Add(new MailAddress("chavalevi@gmail.com"));
                //mail.CC.Add(new MailAddress("chavalopianski@hotmail.com"));

                //smtpClient.Send(mail);


                try
                {
                    var fromAddress = new MailAddress("justJumpApp@gmail.com", "Jump App");
                    string mail = d.getEmail(UserName.Text);
                    var toAddress = new MailAddress(mail);
                    const string fromPassword = "jump1234";
                    const string subject = "Password Recovery for JumpApp";
                    string msg = "Hi " + d.get_client_name_according_to_user_name(UserName.Text) + ",\nyour password is " + d.getPassword(UserName.Text);
                    string body = msg;

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                    };

                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                    Label2.Visible = true;
                    Label2.Text = "Your password had been sent to your email";
                }
                catch (Exception ex)
                {
                    Label2.Visible = true;
                    Label2.Text = "Error occurred while sending the email";
                }
            }
            //else
            //{
            //    Label2.Visible = true;
            //    Label2.Text = "User name does not exist";
            //}
        }

        protected void UserName_TextChanged(object sender, EventArgs e)
        {
            Button1.Visible = true;
        }

        protected void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}