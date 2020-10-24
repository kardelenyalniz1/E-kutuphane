<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KullanıcıEkranı.aspx.cs" Inherits="EkütüphaneWEB1.KullanıcıEkranı" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body style="background-color:powderblue;">
    <form id="form1" runat="server">
        <div style ="color:#800080; text-align:center; background-color: #CCFFFF;">            <h1>KULLANICI EKRANI </h1>

        </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" BackColor="#FF99FF" Height="100px" OnClick="Button1_Click" Text="KİTAP ARA" Width="221px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" BackColor="#FF99FF" Height="99px" OnClick="Button2_Click" Text="KİTAP AL" Width="221px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button3" runat="server" BackColor="#FF99FF" Height="104px" OnClick="Button3_Click" Text="KİTAP VER" Width="219px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
