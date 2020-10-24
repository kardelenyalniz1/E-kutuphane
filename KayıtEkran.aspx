<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KayıtEkran.aspx.cs" Inherits="EkütüphaneWEB1.KayıtEkran" %>

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
            width: 326px;
        }
        .auto-style3 {
            width: 326px;
            height: 31px;
        }
        .auto-style4 {
            height: 31px;
        }
    </style>
</head>
<body  style="background-color:powderblue;">
    <form id="form1" runat="server">

         <div style ="color:#800080; text-align:center; background-color: #CCFFFF;">
            <h1>KULLANICI KAYIT SAYFASI </h1>

        </div>
            
        <table class="auto-style1" style="font-family: 'Imprint MT Shadow'; font-style: italic; font-size: large">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Kullanıcı Adı:</td>
                <td>
                    <asp:TextBox ID="kullanicitxt" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Adı:</td>
                <td>
                    <asp:TextBox ID="aditxt" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Soyadı:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="soyaditxt" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Sifre:</td>
                <td>
                    <asp:TextBox ID="sifretxt" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Height="74px" Text="KAYDET" Width="135px" OnClick="Button1_Click" BackColor="#9999FF" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
