<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="giris.aspx.vb" Inherits="sitemiz1.giris" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" align="center">   <asp:Label ID="Label1" runat="server" Text="Kullanıcı adı :"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label2" runat="server" Text="Şifre:"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server" ForeColor="Black" TextMode="Password"></asp:TextBox>
<br />
<br />
<asp:Button ID="Button1" runat="server" Text="Giriş" />
<br />
<br />
<asp:Label ID="Label3" runat="server" ForeColor="#990000"></asp:Label></div>
 
</asp:Content>
