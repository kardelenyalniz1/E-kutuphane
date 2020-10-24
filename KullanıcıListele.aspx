<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KullanıcıListele.aspx.cs" Inherits="EkütüphaneWEB1.KullanıcıListele" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color:powderblue;">
    <form id="form1" runat="server">
        <div style ="color:#800080; text-align:center; background-color: #CCFFFF;" >
             <h1>ADMİN-KULLANICI LİSTELEME</h1>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Height="92px" OnClick="Button1_Click" Text="Listele" Width="235px" BackColor="#FFCCFF" BorderColor="#CC0099" Font-Italic="True" Font-Size="X-Large" />
            <asp:GridView ID="GridView1" runat="server" Height="126px" Width="562px" BackColor="White" BorderColor="#FF0066">
            </asp:GridView>
        </p>
    </form>
</body>
</html>
