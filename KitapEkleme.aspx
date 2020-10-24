<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KitapEkleme.aspx.cs" Inherits="EkütüphaneWEB1.KitapEkleme" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
<script src="http://code.jquery.com/jquery-1.10.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
          function ImagePreview(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#<%=Image1.ClientID%>').prop('src', e.target.result)
                        .width(200)
                        .height(200);
                };
                reader.readAsDataURL(input.files[0]);
                }
            }

    </script>          
<script src="http://code.jquery.com/jquery-1.10.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
          function ImagePreview1(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#<%=Image2.ClientID%>').prop('src', e.target.result)
                        .width(200)
                        .height(200);
                };
                reader.readAsDataURL(input.files[0]);
                }
            }

    </script>

    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 533px;
        }
        .auto-style10 {
            width: 521px;
            height: 132px;
        }
        .auto-style11 {
            width: 565px;
            height: 132px;
        }
        .auto-style12 {
            width: 521px;
            height: 298px;
        }
        .auto-style13 {
            width: 565px;
            height: 298px;
        }
        .auto-style14 {
            width: 521px;
            height: 39px;
        }
        .auto-style15 {
            width: 565px;
            height: 39px;
        }
        .auto-style16 {
            width: 100%;
        }
        .auto-style17 {
            width: 521px;
            height: 131px;
        }
        .auto-style18 {
            width: 565px;
            height: 131px;
        }
        </style>
</head>
 
<body  style="background-color:powderblue;" >
   
    <form id="form1" runat="server">
        <div> <h1 style ="color:#800080; text-align:center; background-color: #CCFFFF;" >ADMİN-KİTAP EKLEME PANELİ</h1>
        </div>
        <table class="auto-style1"  background-image: url('arka.jpg') style="background-position: -20px; background-image: none; background-attachment: scroll; font-family: 'Imprint MT Shadow'; font-size: large; font-style: italic;">
            <tr>
                <td class="auto-style14">Kitap Adı :</td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBox1" runat="server" Width="334px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">Kitabın Kapak Resmini Ekleyiniz:&nbsp; </td>
                <td class="auto-style18">
                    accept="image/*"<asp:FileUpload ID="FileUpload2" runat="server"  onchange="ImagePreview1(this);" />
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Kitap Arka Resmi Ekleyiniz:</td>
                <td class="auto-style11">accept="image/*" 
                    <asp:FileUpload ID="FileUpload1" accept="image/*" runat="server" onchange="ImagePreview(this);" Width="259px"  
 />
                </td>
            </tr>
            <tr>    
                <td class="auto-style12">
                    <asp:Image ID="Image2" runat="server" Height="225px" Width="253px" />
                    <asp:Image ID="Image1" runat="server" Height="225px" Width="265px" />
                    <table class="auto-style16">
                        <tr>
                            <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style13">
                    <asp:Button ID="Button1" runat="server" Height="103px" Text="Ekle" Width="173px" OnClick="Button1_Click1" BackColor="#CCCCFF" />
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox2" runat="server" Height="30px" Width="418px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox3" runat="server" Width="420px"></asp:TextBox>
                    <br />
                    <br />
                    <asp:TextBox ID="TextBox4" runat="server" Height="48px" Width="395px"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
