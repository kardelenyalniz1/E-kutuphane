<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KitapAlma.aspx.cs" Inherits="EkütüphaneWEB1.KitapAlma" %>

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
            height: 46px;
        }
        .auto-style3 {
            width: 470px;
        }
        .auto-style4 {
            height: 46px;
            width: 470px;
        }
    </style>
</head>
<body  style="background-color:powderblue;">
    <form id="form1" runat="server">
        <div style ="color:#800080; text-align:center; background-color: #CCFFFF;">    <h1>KİTAP AL</h1>
        </div>
        <table class="auto-style1" style="font-family: 'Imprint MT Shadow'; font-size: large; font-style: italic">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Almak istediginiz kitabı seçiniz:</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="204px" OnSelectedIndexChanged="Button1_Click" Width="482px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SEÇ" Width="187px" Height="71px" BackColor="#9999FF" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Height="16px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Height="16px"></asp:TextBox>
                    <asp:TextBox ID="TextBox5" runat="server" Width="340px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" Width="282px"></asp:TextBox>
                    <asp:TextBox ID="TextBox7" runat="server" Width="299px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
