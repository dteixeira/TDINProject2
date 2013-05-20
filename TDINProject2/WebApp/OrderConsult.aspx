<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConsult.aspx.cs" Inherits="OrderConsult" Debug="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" method="get">
        <h1>List Orders</h1>
        <div id="content">
            <p><span>Client Email</span><input type="text" name="email" /></p>
            <span class="spanFormat">
                <asp:Button CssClass="button first" ID="Search" runat="server" OnClick="Search_Orders" Text="Search Orders" />
                <asp:Button CssClass="button" ID="New" runat="server" OnClick="New_Order" Text="New Order" />
            </span>
            <asp:Label ID="Information" runat="server"></asp:Label>
            <asp:Table ID="Table" runat="server">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>Order ID</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Book</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Quantity</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Total Price</asp:TableHeaderCell>
                    <asp:TableHeaderCell>State</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Exp. Date</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
            <asp:PlaceHolder ID="Test" runat="server"></asp:PlaceHolder>
        </div>
    </form>
</body>
</html>