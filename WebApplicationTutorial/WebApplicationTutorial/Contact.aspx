<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplicationTutorial.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr> 425.555.010</address>
    <address>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </address>
    <address>
        <asp:TextBox ID="TextBox1" runat="server" Width="162px"></asp:TextBox>
    </address>
    <address>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="25px" OnClick="Button1_Click" style="margin-left: 0" Text="Button" Width="151px" />
&nbsp;</address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
