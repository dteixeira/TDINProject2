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
    public partial class MainForm : Form
    {
        private readonly static string QueueName = @".\private$\TDINStoreWarehouseQueue";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Start the services.
            StoreServiceHost.Instance.StartServices();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Stop the services.
            StoreServiceHost.Instance.StopServices();
        }
    }
}
