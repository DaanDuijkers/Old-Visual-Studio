<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 40px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 120px;
        }
    </style>
</head>
<body bgcolor = "yellow">
    
    <form id="form1" runat="server">
    <div>
    
        <h1 style = "background-color:blue">ASP.NET from GildeOpleidingen</h1>
        <h2>ASP.NET Web Forms</h2>
        More than a decade of experience and reliability.<br />
        <p class="auto-style1">1. Lots of provided controls</p>
        <p class="auto-style1">2. Thousands of examples available online</p>
        <table class="auto-style2">
            <tr>
                <td class="auto-style3">First Name:</td>
                <td>
                    <asp:TextBox ID="txbFirstName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Family Name:</td>
                <td>
                    <asp:TextBox ID="txbFamilyName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="btnClickMe" runat="server" OnClick="btnClickMe_Click" Text="Click Me" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        </div>
        <asp:Label ID="lblOutput" runat="server"></asp:Label>
    </form>
</body>
</html>
