<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Opdracht 1</h1>
        <h2>
            <asp:Label ID="lblOutput" runat="server" BackColor="#999999"></asp:Label>
        </h2>
        <p>
            <asp:Button ID="btnStart" runat="server" OnClick="btnStart_Click" Text="Start" Height="49px" Width="120px" />
            <asp:Button ID="btnClean" runat="server" Text="Clean" OnClick="btnClean_Click" Height="49px" Width="120px" />
        </p>
    </form>
</body>
</html>
