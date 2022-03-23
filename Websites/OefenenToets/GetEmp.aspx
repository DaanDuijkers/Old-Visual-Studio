<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetEmp.aspx.cs" Inherits="GetEmp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="StudentID" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="StudentID" HeaderText="StudentID" InsertVisible="False" ReadOnly="True" SortExpression="StudentID" />
                    <asp:BoundField DataField="Voornaam" HeaderText="Voornaam" SortExpression="Voornaam" />
                    <asp:BoundField DataField="Achternaam" HeaderText="Achternaam" SortExpression="Achternaam" />
                    <asp:BoundField DataField="Rank" HeaderText="Rank" SortExpression="Rank" />
                </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Table] WHERE [StudentID] = @StudentID" InsertCommand="INSERT INTO [Table] ([Voornaam], [Achternaam], [Rank]) VALUES (@Voornaam, @Achternaam, @Rank)" SelectCommand="SELECT * FROM [Table]" UpdateCommand="UPDATE [Table] SET [Voornaam] = @Voornaam, [Achternaam] = @Achternaam, [Rank] = @Rank WHERE [StudentID] = @StudentID">
                <DeleteParameters>
                    <asp:Parameter Name="StudentID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Voornaam" Type="String" />
                    <asp:Parameter Name="Achternaam" Type="String" />
                    <asp:Parameter Name="Rank" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Voornaam" Type="String" />
                    <asp:Parameter Name="Achternaam" Type="String" />
                    <asp:Parameter Name="Rank" Type="Int32" />
                    <asp:Parameter Name="StudentID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
