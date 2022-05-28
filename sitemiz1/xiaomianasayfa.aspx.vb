Imports System.Data
Imports System.Data.OleDb
Imports System.Security.Cryptography
Public Class xiaomianasayfa
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim yol, sql As String
        yol = Server.MapPath("deneme.accdb")
        sql = "select * from xiaomi"
        Dim baglanti As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        DataList1.DataSource = ds.Tables(0)
        DataList1.DataBind()
    End Sub


End Class