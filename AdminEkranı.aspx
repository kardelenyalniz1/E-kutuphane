<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminEkranı.aspx.cs" Inherits="EkütüphaneWEB1.AdminEkranı" %>

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
            width: 414px;
        }
    </style>
</head>
<body style="background-color:powderblue;">
    <form id="form1" runat="server">
        <div style ="color:#800080; text-align:center; background-color: #CCFFFF;" >            <h1>ADMİN PANELİ</h1>

        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Image ID="Image1" src="book.jpg" runat="server" Height="178px" Width="236px" />
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Height="91px" Text="KİTAP EKLE" Width="217px" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" Height="91px" Text="KULLANICI LİSTELE" Width="217px" OnClick="Button2_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button3" runat="server" Height="91px" Text="ZAMAN ATLAMA İŞLEMİ " Width="217px" OnClick="Button3_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
