<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KitapVerme.aspx.cs" Inherits="EkütüphaneWEB1.KitapVerme" %>

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
            width: 503px;
        }
    </style>
</head>
<body  style="background-color:powderblue;">
    <form id="form1" runat="server">
        <div style ="color:#800080; text-align:center; background-color: #CCFFFF;"><h1>KİTABI İADE ETME PANELİ
             </h1>
        </div>
        <table class="auto-style1" style="font-family: 'Imprint MT Shadow'; font-size: large; font-style: italic">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Geri vermek istediginiz kitabın resmini yükleyiniz lütfen"></asp:Label>
&nbsp;:</td>
                <td>
                    accept="image/*" 
                    <asp:FileUpload ID="FileUpload1" accept="image/*" runat="server" onchange="ImagePreview(this);"
 />
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
                    <asp:Button ID="Button1" runat="server" Height="63px" OnClick="Button1_Click" Text="GERİ VER" Width="190px" BackColor="#FFCCFF" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server" Width="368px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
