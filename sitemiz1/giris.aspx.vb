Public Class giris
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kullanici, sifre As String
        kullanici = TextBox1.Text
        sifre = TextBox2.Text
        If kullanici = "admin" And sifre = "123" Then
            Label3.Text = "Giriş Başarılı, HOŞGELDİN ADMİN"

            Response.Redirect("diğertelefonlaradmin.aspx")



        Else
            Label3.Text = "Kullcanıcı adı veya şifre yanlış"

        End If
    End Sub
End Class