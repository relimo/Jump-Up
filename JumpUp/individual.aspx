<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="individual.aspx.cs" Inherits="JumpUp.individual" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

   <%--  <form id="form1" runat="server">--%>
           <div class="heading_dots_grey  hide-for-smal">
            <h4 class="heading_supersize" style="margin-bottom:0"><span class="heading_bg">  
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>'s Lessons:
                </span></h4>
         
          </div>

    
    <asp:GridView ID="GridView1"  RowStyle-HorizontalAlign ="Center" RowStyle-VerticalAlign="Middle" runat="server" Visible="true" AutoGenerateColumns="true" Width="700px" OnRowDeleting="GridView1_RowDeleting"  >
       <Columns>
          <%--  <asp:CommandField ControlStyle-CssClass="btn" ShowDeleteButton="True" ButtonType="Button" ControlStyle-BackColor="#af9aae" ControlStyle-BorderStyle="Groove" ControlStyle-Font-Names="Economica" ControlStyle-Width="80px" ControlStyle-Height="50px" ControlStyle-Font-Size="20px"  />--%>
        <asp:CommandField ControlStyle-CssClass="btn" ShowDeleteButton="True" ButtonType="Button" ControlStyle-BackColor="#af9aae" ControlStyle-BorderStyle="Groove" ControlStyle-Font-Names="Arial"  ControlStyle-Font-Size="20px"  >
<ControlStyle BackColor="#AF9AAE" BorderStyle="Groove" CssClass="btn" Font-Names="Arial" Font-Size="20px"></ControlStyle>
           </asp:CommandField>
           
        </Columns>

<RowStyle HorizontalAlign="Center" BorderStyle="Dashed"></RowStyle>
        </asp:GridView>
      
   <p><a class="large secondary button"  href="">Add A New Lesson</a></p>
    
      <%--  </form>--%>




 
</asp:Content>
