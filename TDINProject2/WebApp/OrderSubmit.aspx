<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderSubmit.aspx.cs" Inherits="OrderSubmit" Debug="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <h1>Order Confirmation</h1>
    <form id="form2" runat="server">
        <asp:PlaceHolder runat="server">
            <div id="content">
                <p><span>Full Name </span>
                    <asp:Label ID="Label1" runat="server" Text="Label" CssClass="info"></asp:Label></p>
                <p><span>Email </span>
                    <asp:Label ID="Label2" runat="server" Text="Label" CssClass="info"></asp:Label></p>
                <p><span>Address </span>
                    <asp:Label ID="Label3" runat="server" Text="Label" CssClass="info"></asp:Label></p>
                <p><span>Book </span>
                    <asp:Label ID="Label4" runat="server" Text="Label" CssClass="info"></asp:Label></p>
                <p><span>Quantity </span>
                    <asp:Label ID="Label5" runat="server" Text="Label" CssClass="info"></asp:Label></p>
                <p><span>Total Price</span><asp:Label ID="Label6" runat="server" Text="Label" CssClass="info"></asp:Label></p>
                <asp:HiddenField ID="ClientEmail" runat="server" />
                <asp:Button ID="Confirm" runat="server" OnClick="Confirm_Click" Text="Confirm Order" CssClass="button first" />
                <asp:Button PostBackUrl="~/Default.aspx" ID="Cancel" runat="server" Text="Cancel Order" CssClass="button" />
            </div>
        </asp:PlaceHolder>
    </form>
</body>
</html>