using System;
using System.Web.UI;

public partial class _Default : System.Web.UI.Page
{
    protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        form1.Action = "OrderSubmit.aspx";
        BookStoreService.BookStoreServiceClient client = new BookStoreService.BookStoreServiceClient();
        client.Open();
        var books = client.GetAllBooks();
        client.Close();
        foreach (var book in books)
        {
            System.Web.UI.WebControls.ListItem item = new System.Web.UI.WebControls.ListItem();
            item.Value = book.BookID.ToString();
            item.Text = String.Format("{0} - €{1:N}", book.Title, book.Price);
            this.BooksList.Items.Add(item);
        }
    }
}