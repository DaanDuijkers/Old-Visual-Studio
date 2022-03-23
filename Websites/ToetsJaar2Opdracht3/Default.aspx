<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Hoeveel meter heeft u de bal weten te gooien:</h1>
&nbsp;<asp:TextBox ID="txbGetal" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnClick" runat="server" Text="Click me!" OnClick="btnClick_Click" /><br />
        <asp:Label ID="lblOutput" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
