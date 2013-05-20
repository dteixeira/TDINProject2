using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoreApp
{
    public partial class SellPopupForm : Form
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public SellPopupForm(double price)
        {
            InitializeComponent();
            this.Quantity = 1;
            this.Price = price;
            this.TotalPriceLabel.Text = String.Format("{0:N} Euros", this.Price);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int value = (int)((NumericUpDown)sender).Value;
            this.Quantity = value;
            this.TotalPriceLabel.Text = String.Format("{0:N} Euros", this.Quantity * this.Price);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            this.Name = this.NameTextBox.Text;
            this.Email = this.EmailTextBox.Text;
            this.Address = this.AddressTextBox.Text;
        }
    }
}
