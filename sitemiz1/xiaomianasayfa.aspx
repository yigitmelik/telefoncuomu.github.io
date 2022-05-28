<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site1.Master" CodeBehind="xiaomianasayfa.aspx.vb" Inherits="sitemiz1.xiaomianasayfa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="carouselExampleCaptions" class="carousel slide" data-bs-ride="carousel">
        <div class="carousel-indicators">
            <button aria-current="true" aria-label="Slide 1" class="active" data-bs-slide-to="0" data-bs-target="#carouselExampleCaptions" type="button">
            </button>
            <button aria-label="Slide 2" data-bs-slide-to="1" data-bs-target="#carouselExampleCaptions" type="button">
            </button>
            <button aria-label="Slide 3" data-bs-slide-to="2" data-bs-target="#carouselExampleCaptions" type="button">
            </button>
        </div>
       <div class="carousel-inner">
            <div class="carousel-item active">
                <img alt="..." class="d-block w-100" src="img/6.jpg" />
                <div class="carousel-caption d-none d-md-block">
                    <h5>Samsung</h5>
                    <p>
                        Yeni Samsung A31 ile Bambaşka bir Dünya.</p>
                </div>
            </div>
            <div class="carousel-item">
                <img alt="..." class="d-block w-100" src="img/7.png" />
                <div class="carousel-caption d-none d-md-block">
                    <h5>Xiaomi</h5>
                    <p>
                        Yeni Xiaomi Mi 10 Pro ile Su Yeşilinin Farkına Varın</p>
                </div>
            </div>
            <div class="carousel-item">
                <img alt="..." class="d-block w-100" src="img/iphone13yan.jpg" />
                <div class="carousel-caption d-none d-md-block">
                    <h5>İphone</h5>
                    <p>
                        Yeni İphone 13 Mağazamızda</p>
                </div>
            </div>
        </div>
        <button class="carousel-control-prev" data-bs-slide="prev" data-bs-target="#carouselExampleCaptions" type="button">
            <span aria-hidden="true" class="carousel-control-prev-icon"></span><span class="visually-hidden">Previous</span>
        </button>
        <button class="carousel-control-next" data-bs-slide="next" data-bs-target="#carouselExampleCaptions" type="button">
            <span aria-hidden="true" class="carousel-control-next-icon"></span><span class="visually-hidden">Next</span>
        </button>
    </div>
    <hr />

    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal" Height="371px" Width="843px" >
        <ItemTemplate>
            <table>
                <tr>
                   
                    <td valign="right">
                        <image ID="Img1" runat="server" align="right" src='<%# DataBinder.Eval(Container.DataItem, "urun", "img/{0}.jpg")%>' width="350" />
                    </td>
                    <td valign="right">urun:<%# DataBinder.Eval(Container.DataItem, "urun") %><br></br>
                        aciklama:<%# DataBinder.Eval(Container.DataItem, "aciklama") %><br></br>
                        fiyat:<%# DataBinder.Eval(Container.DataItem, "fiyat") %><br></br>
                        stok:<%# DataBinder.Eval(Container.DataItem, "stok") %><br></br>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>

</asp:Content>
