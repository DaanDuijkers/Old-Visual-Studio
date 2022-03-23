<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 400px;
        }
        .auto-style2 {
            margin-left: 560px;
        }
        .auto-style3 {
            margin-left: 480px;
        }
        .auto-style4 {
            margin-left: 520px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h1>RekenBewerking</h1>
        <div class="blue">
            <p class="auto-style1">
                Frist Number&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txbGetal1" runat="server"></asp:TextBox>
            </p>
        </div>
        
        <div class="blue">
            <p class="auto-style1">
                Operator&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txbOperator" runat="server" Width="48px"></asp:TextBox>
        
            </p>
        </div>
        
        <div class="blue">
            <p class="auto-style1">
                Second number&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txbGetal2" runat="server"></asp:TextBox>
        
            </p>
        </div>
        
        <div class="blue">
            <p class="auto-style2">
                =</p>
        </div>
        <div class="blue">
            <p class="auto-style3">
                Results&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblOutput" runat="server" BackColor="Lime" ForeColor="Black"></asp:Label>
            </p>
        </div>
        <p class="auto-style4">
        <asp:Button ID="btnStart" runat="server" Text="Start" Height="44px" OnClick="btnStart_Click" Width="118px" />
        <asp:Button ID="btnClean" runat="server" Text="Clean" Height="44px" OnClick="btnClean_Click" Width="121px" />
        </p>
        <div id="mudi">
            <p class="auto-style3">
                Made by Mudi</p>
        </div>
    </form>
</body>
</html>
