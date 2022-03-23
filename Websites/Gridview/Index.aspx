<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <body>
        <form id="form1" runat="server">
            <div>

                <asp:DropDownList ID="ddlSpelers" runat="server" AutoPostBack="True" DataSourceID="sdsSpelers" DataTextField="Speler_Voornaam" DataValueField="Speler_Voornaam" OnSelectedIndexChanged="ddlSpelers_SelectedIndexChanged">
                </asp:DropDownList>
                <asp:SqlDataSource ID="sdsSpelers" runat="server" ConnectionString="<%$ ConnectionStrings:TennistoernooiConnectionString %>" SelectCommand="SELECT [Speler_Voornaam] FROM [SPELER]"></asp:SqlDataSource>
                <br />
                <asp:GridView ID="grdSpelers" runat="server">
                </asp:GridView>

            </div>
        </form>
    </body>
</html>
