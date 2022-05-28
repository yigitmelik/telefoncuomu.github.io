Imports System.Data
Imports System.Data.OleDb
Imports System.Security.Cryptography
Public Class admin
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        verigöster()

    End Sub
    Private Sub verigöster()
        Dim yol, sql As String
        yol = Server.MapPath("deneme.accdb")
        sql = "select * from urun"
        Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        GridView1.DataSource = ds.Tables(0)
        GridView1.DataBind()
    End Sub
    Private Sub temizle()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" Then
            Dim telkodd, ürün, fiyat, aciklama, stok, yol, sql As String
            telkodd = TextBox1.Text
            ürün = TextBox2.Text
            fiyat = TextBox3.Text
            aciklama = TextBox4.Text
            stok = TextBox5.Text
            yol = Server.MapPath("deneme.accdb")
            sql = " Insert into urun (telkod,urun,fiyat,aciklama,stok) values ('" & telkodd & "','" & ürün & "','" & fiyat & "','" & aciklama & "','" & stok & "')"
            Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & yol)
            Dim komut_kontrol As New OleDbCommand("select * from urun where telkod= " & telkodd & "", baglanti)
            Dim verioku As OleDbDataReader
            baglanti.Open()
            verioku = komut_kontrol.ExecuteReader
            If verioku.HasRows Then
                Label5.Text = "Ürün zaten kayıtlı!"
                baglanti.Close()
            Else
                baglanti.Close()
                Dim komut As New OleDbCommand
                komut.Connection = baglanti
                komut.CommandText = sql

                baglanti.Open()
                komut.ExecuteNonQuery()
                baglanti.Close()
                Label5.Text = "Kayıt başarılı!!"
                temizle()
                verigöster()

            End If
        Else
            Label5.Text = "Lütfen boş bırakmayın!!"

        End If



    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim telkodd, sql, yol As String
        telkodd = TextBox1.Text
        yol = Server.MapPath("deneme.accdb")
        sql = " Delete * from urun Where telkod=" & telkodd & ""
        Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & yol)
        Dim komut As New OleDbCommand
        komut.Connection = baglanti
        komut.CommandText = sql
        baglanti.Open()
        komut.ExecuteNonQuery()
        baglanti.Close()
        Label5.Text = "Kayıt başarılı bir şekilde silindi!!"
        temizle()
        verigöster()
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim telkodd, ürün, fiyat, aciklama, stok, sql, yol As String
        telkodd = TextBox1.Text
        ürün = TextBox2.Text
        fiyat = TextBox3.Text
        aciklama = TextBox4.Text
        stok = TextBox5.Text
        yol = Server.MapPath("deneme.accdb")
        Dim baglantı As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        sql = "update urun set telkod= '" & telkodd & "', urun='" & ürün & "', fiyat='" & fiyat & "', aciklama='" & aciklama & "', stok='" & stok & "' where telkod= " & telkodd & ""
        Dim komut As New OleDbCommand
        komut.CommandText = sql
        komut.Connection = baglantı
        baglantı.Open()
        komut.ExecuteNonQuery()
        baglantı.Close()
        Label5.Text = "güncelleme başarılı !!!"
        temizle()
        verigöster()
    End Sub



    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim telkodd, yol, sql As String
        telkodd = TextBox1.Text
        yol = Server.MapPath("deneme.accdb")
        sql = "select * from urun where telkod= " & telkodd & ""
        Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & yol)
        Dim komut_kontrol As New OleDbCommand("select * from urun where telkod= " & telkodd & "", baglanti)
        Dim verioku As OleDbDataReader
        baglanti.Open()
        verioku = komut_kontrol.ExecuteReader
        If verioku.Read Then
            TextBox1.Text = verioku(0)
            TextBox2.Text = verioku(1)
            TextBox3.Text = verioku(2)
            TextBox4.Text = verioku(3)
            TextBox5.Text = verioku(4)
        Else
           Label5.Text = "Kayıtlı ürün bulunamadı!!"


        End If
        baglanti.Close()
    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If FileUpload1.HasFile Then

            Dim fotourl, yol, sql As String
            FileUpload1.SaveAs(Server.MapPath("img/" & FileUpload1.FileName))
            fotourl = "img/" & FileUpload1.FileName
            yol = Server.MapPath("deneme.accdb")
            sql = "Insert into fotolar (fotourl) Values ('" & fotourl & "')"

            Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & yol)

            Dim komut As New OleDbCommand
            komut.Connection = baglanti
            komut.CommandText = sql
            baglanti.Open()
            komut.ExecuteNonQuery()
            baglanti.Close()
        Else
            Label6.Text = "Lütfen Dosya Seçin"

        End If
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim urun, yol, sql As String
        urun = TextBox2.Text
        yol = Server.MapPath("deneme.accdb")
        sql = "select * from urun where urun like '%" & TextBox2.Text & "%'"
        Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & yol)
        Dim verial As New OleDbDataAdapter(sql, baglanti)
        Dim ds As New DataSet
        verial.Fill(ds)
        GridView1.DataSource = ds.Tables(0)
        GridView1.DataBind()
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        verigöster()
        temizle()
    End Sub
End Class