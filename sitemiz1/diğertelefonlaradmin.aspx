<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site3.Master" CodeBehind="diğertelefonlaradmin.aspx.vb" Inherits="sitemiz1.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


*,
*::before,
*::after {
  box-sizing: border-box;
}

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    tel kodu:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Diğer telefonlar<br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="ürün"></asp:Label>
    :<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" Text="ara" />
&nbsp;
    <asp:Button ID="Button6" runat="server" Text="bul" />
&nbsp;
    <asp:Button ID="Button7" runat="server" Text="hepsini listele" />
<br />
<br />
<asp:Label ID="Label2" runat="server" Text="fiyat"></asp:Label>
    :<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label3" runat="server" Text="acıklama"></asp:Label>
    :<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label4" runat="server" Text="stok"></asp:Label>
    :<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <br />
    <br />
    resim ekle:
    <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button5" runat="server" Height="20px" Text="ekle" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label6" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <br />
<br />
<asp:Button ID="Button1" runat="server" Text="kaydet" />
&nbsp;
    <asp:Button ID="Button2" runat="server" Text="sil" />
&nbsp;
    <asp:Button ID="Button3" runat="server" Text="güncelle" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
<br />
<asp:Label ID="Label5" runat="server" ForeColor="Red"></asp:Label>
&nbsp;&nbsp;&nbsp;<br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
    &nbsp;&nbsp;&nbsp;
    &nbsp; <br />
<br />
<asp:GridView ID="GridView1" runat="server" Width="613px" CellPadding="4" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:CommandField InsertText="Düzenle" EditText="Güncelle" />
        <asp:ImageField DataImageUrlField="urun" DataImageUrlFormatString="img/{0}.jpg" HeaderText="Fotoğraflar">
            <ControlStyle Height="100px" Width="100px" />
        </asp:ImageField>
    </Columns>
    <EditRowStyle BackColor="#2461BF" />
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#EFF3FB" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F5F7FB" />
    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
    <SortedDescendingCellStyle BackColor="#E9EBEF" />
    <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
<br />
<br />
</asp:Content>
