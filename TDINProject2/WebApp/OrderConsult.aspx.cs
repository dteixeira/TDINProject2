using System;
using System.Linq;
using System.Web.UI.WebControls;

public partial class OrderConsult : System.Web.UI.Page
{
    protected void New_Order(object sender, EventArgs e)
    {
        Server.Transfer("Default.aspx");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        string email = Request.QueryString["email"];
        Table.Visible = false;
        if (email != null)
        {
            BookStoreService.BookStoreServiceClient client = new BookStoreService.BookStoreServiceClient();
            var orders = client.GetAllOrdersByEmail(email);
            client.Close();

            if (orders.Count() == 0)
            {
                Information.Text = "This client has no orders registered";
                Table.Visible = false;
            }
            else
            {
                Information.Text = "Orders of " + orders[0].Client.Name;
                Table.Visible = true;
                foreach (var order in orders)
                {
                    TableRow row = new TableRow();
                    TableCell id = new TableCell();
                    id.Text = order.OrderID.ToString();
                    TableCell book = new TableCell();
                    book.Text = order.Book.Title;
                    TableCell quantity = new TableCell();
                    quantity.Text = order.Quantity.ToString();
                    TableCell totalPrice = new TableCell();
                    totalPrice.Text = String.Format("€{0:N}", order.Quantity * order.Book.Price);
                    TableCell state = new TableCell();
                    state.Text = order.State.ToString();
                    TableCell expDate = new TableCell();
                    expDate.Text = order.ExpDate == null ? "" : String.Format("{0:d}", order.ExpDate);
                    row.Controls.Add(id);
                    row.Controls.Add(book);
                    row.Controls.Add(quantity);
                    row.Controls.Add(totalPrice);
                    row.Controls.Add(state);
                    row.Controls.Add(expDate);
                    Table.Controls.Add(row);
                }
            }
        }
    }

    protected void Search_Orders(object sender, EventArgs e)
    {
    }
}