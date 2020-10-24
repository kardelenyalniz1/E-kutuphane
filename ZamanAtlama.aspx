<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZamanAtlama.aspx.cs" Inherits="EkütüphaneWEB1.ZamanAtlama" %>

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
            width: 445px;
        }
    </style>
</head>
<body style="background-color:powderblue;" >
    <form id="form1" runat="server">
        <div style ="color:blue; text-align:center; background-color: #CCFFFF;"><h1>ZAMAN ATLAMA MODÜLÜ</h1>
        </div>
        <table class="auto-style1" style="font-family: 'Imprint MT Shadow'; font-size: large; font-style: italic; font-variant: normal; font-weight: normal; text-decoration: blink;">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Atlamak istediginiz gün sayısını giriniz: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="279px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="ATLA" Height="53px" OnClick="Button1_Click" Width="195px" BackColor="#FFCCFF" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
