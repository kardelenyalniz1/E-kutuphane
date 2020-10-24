<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KitapArama.aspx.cs" Inherits="EkütüphaneWEB1.KitapArama" %>

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
            width: 376px;
        }
        .auto-style3 {
            width: 422px;
        }
        .auto-style4 {
            width: 376px;
            height: 34px;
        }
        .auto-style5 {
            width: 422px;
            height: 34px;
        }
        .auto-style6 {
            height: 34px;
        }
        .auto-style7 {
            width: 376px;
            height: 28px;
        }
        .auto-style8 {
            width: 422px;
            height: 28px;
        }
        .auto-style9 {
            height: 28px;
        }
    </style>
</head>
<body style="background-color:powderblue;">
    <form id="form1" runat="server">
             <div style ="color:#800080; text-align:center; background-color: #CCFFFF;">
            <h1>KİTAP ARA </h1>

        </div>
             <table class="auto-style1">
                 <tr>
                     <td class="auto-style2">&nbsp;</td>
                     <td class="auto-style3">&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
                 <tr>
                     <td class="auto-style2">
                         <asp:Label ID="Label1" runat="server" Text="Kitap Adı :"></asp:Label>
                     </td>
                     <td class="auto-style3">
                         <asp:TextBox ID="TextBox1" runat="server" Width="290px"></asp:TextBox>
                     </td>
                     <td>
                         <asp:Button ID="Button1" runat="server" Height="71px" OnClick="Button1_Click1" Text="ARA" Width="171px" />
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style4">
                         <asp:Label ID="Label2" runat="server" Text="ISBN"></asp:Label>
&nbsp;:</td>
                     <td class="auto-style5">
                         <asp:TextBox ID="TextBox2" runat="server" Width="285px"></asp:TextBox>
                     </td>
                     <td class="auto-style6">
                         <asp:Button ID="Button2" runat="server" Height="71px" OnClick="Button2_Click" Text="ARA" Width="171px" />
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style7"></td>
                     <td class="auto-style8"></td>
                     <td class="auto-style9"></td>
                 </tr>
                 <tr>
                     <td class="auto-style2">
                         <asp:Label ID="Label3" runat="server" Text="+"></asp:Label>
                     </td>
                     <td class="auto-style3">&nbsp;</td>
                     <td>
                         <asp:Label ID="Label4" runat="server" Text="+"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style2">&nbsp;</td>
                     <td class="auto-style3">&nbsp;</td>
                     <td>&nbsp;</td>
                 </tr>
             </table>
    </form>
</body>
</html>
