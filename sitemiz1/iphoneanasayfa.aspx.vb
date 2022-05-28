Imports System.Data
Imports System.Data.OleDb
Imports System.Security.Cryptography
Public Class kullanıcıgirisi
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim yol, sql As String
        yol = Server.MapPath("deneme.accdb")
        sql = "select * from iphone"
        Dim baglanti As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        DataList2.DataSource = ds.Tables(0)
        DataList2.DataBind()
    End Sub


End Class