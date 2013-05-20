<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Debug="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <h1>New Order</h1>
    <div id="content">

        <asp:Panel ID="Panel1" runat="server">
            <div id="container">
                <form id="form1" runat="server">
                    <p>
                        <span>Book </span>
                        <asp:DropDownList ID="BooksList" runat="server" name="books" required="required"></asp:DropDownList>
                    </p>
                    <p>
                        <span>Quantity </span>
                        <input type="number" min="1" value="1" name="quantity" required="required" />
                    </p>
                    <p>
                        <span>Full Name </span>
                        <input type="text" name="name" required="required" />
                    </p>
                    <p>
                        <span>Email </span>
                        <input type="text" name="email" required="required" /></p>
                    <p><span>Address </span>
                        <input type="text" name="address" required="required" /></p>
                    <input class="button" type="submit" value="Submit Order" />
                    <asp:HyperLink CssClass="button" NavigateUrl="~/OrderConsult.aspx" runat="server" Text="Search Orders"></asp:HyperLink>
                </form>
            </div>
        </asp:Panel>
    </div>
</body>
</html>