<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GirisEkran.aspx.cs" Inherits="EkütüphaneWEB1.GirisEkran" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 366px;
        }
        .auto-style3 {
            width: 366px;
            height: 90px;
        }
        .auto-style4 {
            height: 90px;
        }
    </style>
</head>
<body style="background-color:powderblue;">
    <form id="form1" runat="server">
          <div style ="color:blue; text-align:center; background-color: #CCFFFF;">
            <h1 style="color: #800080">KULLANICI GİRİŞ SAYFASI </h1>
             
        </div>
        <table class="auto-style1" style="font-family: 'Imprint MT Shadow'; font-size: large; font-style: italic">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Kullanıcı Adı:</td>
                <td>
                    <asp:TextBox ID="kullanicitxt" runat="server" Height="25px" Width="213px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Sifre:</td>
                <td>
                    <asp:TextBox ID="sifretxt" runat="server" Width="213
                        px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">
                    <asp:Button ID="Button2" runat="server" Height="78px" OnClick="Button2_Click" Text="Giriş Yap" Width="176px" BackColor="#CCCCFF" BorderColor="Black" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
