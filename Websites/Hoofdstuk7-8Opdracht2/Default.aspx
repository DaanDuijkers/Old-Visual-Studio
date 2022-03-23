<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body{
            background-color: #42f1f4;
            text-align: center;
            font-size: 20px;
        }

        h1{
            background-color: #f4d742;
            text-align: center;
            width: 800px;
            margin-left: auto;
            margin-right: auto;
        }

        h2{
            text-align: center;
        }

        .text{
            text-align: center;
            color: red;
        }

        .auto-style1 {
            width: 24%;
            margin-left: auto;
            margin-right: auto;
        }
        .auto-style2 {
            width: 201px;
        }
        .auto-style3 {
            width: 112px;
            text-align: center;
        }
        .auto-style4 {
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <b>
            <h1>ASP.NET from GildeOpleidingen</h1>
            <h2>ASP.Net Web Forms</h2>
        </b>
        More than a decade of experience and reliability<br />
        <br />
        <div class="text">
            1. Lots of provided controls<br />
            2. Thousants of examples available online
        </div>
        <br />
        <table class="auto-style1" border="1">
            <tr>
                <td class="auto-style3">First Name:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txbVoornaam" runat="server" Width="223px" CssClass="auto-style4" Height="24px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Family Name:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txbAchternaam" runat="server" Width="223px" Height="24px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Age:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txbLeeftijd" runat="server" Width="223px" Height="24px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <p>
            <asp:Button ID="btnClick" runat="server" Text="Click me" OnClick="btnClick_Click" />
        </p>
        <asp:Label ID="lblOutput" runat="server" Font-Size="X-Large"></asp:Label>
    </form>
</body>
</html>
