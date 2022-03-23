<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ToetsOefening1.aspx.cs" Inherits="ToetsOefening1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 216px;
        }
        .auto-style3 {
            width: 216px;
            height: 29px;
        }
        .auto-style4 {
            height: 29px;
        }
        .auto-style5 {
            width: 216px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Wie ben je</h1>
        <br />
        Vul de onderstaande vragen in:
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Naam:</td>
                <td>
                    <asp:TextBox ID="txbNaam" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Geslacht:</td>
                <td>
                    <asp:RadioButtonList ID="rbGeslacht" runat="server" RepeatDirection="Horizontal">
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Hobby:</td>
                <td class="auto-style6">
                    <asp:CheckBox ID="chbHobby" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Opleiding:</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="cbOpleiding" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnMaakKaart" runat="server" Text="Maak persoon aan" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
