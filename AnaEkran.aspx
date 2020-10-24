<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnaEkran.aspx.cs" Inherits="EkütüphaneWEB1.AnaEkran" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="background-color:powderblue">
    <form id="form1" runat="server">
        <div>
            <asp:Button center ID="kayıtol_button" runat="server"  Height="167px" OnClick="kayıtol_button_Click" Text="KAYIT OL" Width="278
                px" BackColor="#33CCFF" BorderStyle="Solid" />
        </div>
        <p>
            <asp:Button  ID="girisyap_button" runat="server" Height="167px" OnClick="girisyap_button_Click" Text="GİRİŞ YAP" Width="278px" BackColor="#33CCFF" BorderStyle="Solid" />
        </p>
    </form>
   
</body>
  


   
</html>

