using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderSubmit : System.Web.UI.Page
{
    protected void Confirm_Click(object sender, EventArgs e)
    {
        BookStoreService.BookStoreServiceClient client = new BookStoreService.BookStoreServiceClient();
        client.Open();
        BookStoreService.Order order = (BookStoreService.Order)Session["Order"];
        client.CreateOrder(order);
        client.Close();
        Server.Transfer("OrderConsult.aspx?email=" + order.Client.Email);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            // Parse form values
            string name = Request.Form["name"];
            string email = Request.Form["email"];
            string address = Request.Form["address"];
            int quantity = int.Parse(Request.Form["quantity"]);
            int bookID = int.Parse(Request.Form["BooksList"]);
            BookStoreService.BookStoreServiceClient client = new BookStoreService.BookStoreServiceClient();
            client.Open();
            var book = client.GetAllBooks().FirstOrDefault(b => b.BookID == bookID);
            client.Close();

            // Add client information
            Label1.Text = name;
            Label2.Text = email;
            Label3.Text = address;
            Label4.Text = book.Title;
            Label5.Text = quantity.ToString();
            Label6.Text = String.Format("€{0:N}", book.Price * quantity);

            // Save order.
            Session["Order"] = new BookStoreService.Order
            {
                Book = new BookStoreService.Book { BookID = bookID },
                Client = new BookStoreService.Client { Address = address, Email = email, Name = name },
                Quantity = quantity
            };
        }
        catch (Exception)
        {
        }
    }
}