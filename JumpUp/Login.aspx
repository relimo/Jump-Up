<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="JumpUp.Login" %>

<%@ MasterType VirtualPath="~/Site1.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>Please enter your username and password.<a href="Registera.aspx">Register</a>  if you don't have an account. </p>
<%--<form id="form1" runat="server">--%>


                     <span>
                        <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
                    </span>
                    <asp:ValidationSummary ID="RegisterUserValidationSummary" runat="server" 
                         ValidationGroup="RegisterUserValidationGroup"/>
                    <fieldset>
            <legend>Account Information</legend>
                     <p>
                     <asp:Label ID="Label1" runat="server" >User Name:</asp:Label>
                              
                                <asp:TextBox ID="UserName" runat="server" Width="200px" OnTextChanged="UserName_TextChanged" ></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                                      ErrorMessage="User Name is required." ToolTip="User Name is required." 
                                     ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
                     
                       
                           
                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                                <asp:TextBox ID="Password" runat="server" TextMode="Password" 
                             Width="200px"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="Forgot password?" OnClick="Button1_Click" />
                         <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" 
                                    ErrorMessage="Password is required." ToolTip="Password is required." 
                                     ValidationGroup="RegisterUserValidationGroup">*</asp:RequiredFieldValidator>
      

                                <asp:Label ID="err" runat="server" ForeColor="Red" Visible="False"></asp:Label>
                     
                          
                      </fieldset>
                      <p>
                            <asp:Button class="button tiny primary" ID="loginButton" runat="server" CommandName="MoveNext" Text="Log in" 
                                 ValidationGroup="RegisterUserValidationGroup" onclick="loginButton_Click" 
                                BackColor="#CCCCCC" BorderColor="#666666" Font-Bold="True" 
                                Font-Names="MS Gothic" Font-Size="Larger" 
                                   />
                        </p>





<%--    </form> --%>
   
      
 


</asp:Content>
