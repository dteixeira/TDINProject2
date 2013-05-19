namespace WarehouseApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PendingDeliveryTabPage = new System.Windows.Forms.TabPage();
            this.CompleteDeliveryButton = new System.Windows.Forms.Button();
            this.PendentDeliveryListView = new System.Windows.Forms.ListView();
            this.deliveryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompletedDeliveryTabPage = new System.Windows.Forms.TabPage();
            this.CompletedDeliveryListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.PendingDeliveryTabPage.SuspendLayout();
            this.CompletedDeliveryTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PendingDeliveryTabPage);
            this.tabControl1.Controls.Add(this.CompletedDeliveryTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // PendingDeliveryTabPage
            // 
            this.PendingDeliveryTabPage.Controls.Add(this.CompleteDeliveryButton);
            this.PendingDeliveryTabPage.Controls.Add(this.PendentDeliveryListView);
            this.PendingDeliveryTabPage.Location = new System.Drawing.Point(4, 22);
            this.PendingDeliveryTabPage.Name = "PendingDeliveryTabPage";
            this.PendingDeliveryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PendingDeliveryTabPage.Size = new System.Drawing.Size(778, 537);
            this.PendingDeliveryTabPage.TabIndex = 0;
            this.PendingDeliveryTabPage.Text = "Pending Deliveries";
            this.PendingDeliveryTabPage.UseVisualStyleBackColor = true;
            // 
            // CompleteDeliveryButton
            // 
            this.CompleteDeliveryButton.Location = new System.Drawing.Point(627, 6);
            this.CompleteDeliveryButton.Name = "CompleteDeliveryButton";
            this.CompleteDeliveryButton.Size = new System.Drawing.Size(141, 26);
            this.CompleteDeliveryButton.TabIndex = 2;
            this.CompleteDeliveryButton.Text = "Complete Delivery";
            this.CompleteDeliveryButton.UseVisualStyleBackColor = true;
            this.CompleteDeliveryButton.Click += new System.EventHandler(this.CompleteDeliveryButton_Click);
            // 
            // PendentDeliveryListView
            // 
            this.PendentDeliveryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.deliveryID,
            this.orderID,
            this.bookTitle,
            this.bookAuthor,
            this.quantity});
            this.PendentDeliveryListView.FullRowSelect = true;
            this.PendentDeliveryListView.GridLines = true;
            this.PendentDeliveryListView.Location = new System.Drawing.Point(8, 38);
            this.PendentDeliveryListView.Name = "PendentDeliveryListView";
            this.PendentDeliveryListView.Size = new System.Drawing.Size(760, 489);
            this.PendentDeliveryListView.TabIndex = 1;
            this.PendentDeliveryListView.UseCompatibleStateImageBehavior = false;
            this.PendentDeliveryListView.View = System.Windows.Forms.View.Details;
            // 
            // deliveryID
            // 
            this.deliveryID.Text = "DeliveryID";
            this.deliveryID.Width = 0;
            // 
            // orderID
            // 
            this.orderID.Text = "OrderID";
            this.orderID.Width = 250;
            // 
            // bookTitle
            // 
            this.bookTitle.Text = "Title";
            this.bookTitle.Width = 250;
            // 
            // bookAuthor
            // 
            this.bookAuthor.Text = "Author";
            this.bookAuthor.Width = 150;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 100;
            // 
            // CompletedDeliveryTabPage
            // 
            this.CompletedDeliveryTabPage.Controls.Add(this.CompletedDeliveryListView);
            this.CompletedDeliveryTabPage.Location = new System.Drawing.Point(4, 22);
            this.CompletedDeliveryTabPage.Name = "CompletedDeliveryTabPage";
            this.CompletedDeliveryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CompletedDeliveryTabPage.Size = new System.Drawing.Size(778, 537);
            this.CompletedDeliveryTabPage.TabIndex = 1;
            this.CompletedDeliveryTabPage.Text = "Completed Deliveries";
            this.CompletedDeliveryTabPage.UseVisualStyleBackColor = true;
            // 
            // CompletedDeliveryListView
            // 
            this.CompletedDeliveryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.CompletedDeliveryListView.GridLines = true;
            this.CompletedDeliveryListView.Location = new System.Drawing.Point(8, 6);
            this.CompletedDeliveryListView.Name = "CompletedDeliveryListView";
            this.CompletedDeliveryListView.Size = new System.Drawing.Size(760, 521);
            this.CompletedDeliveryListView.TabIndex = 2;
            this.CompletedDeliveryListView.UseCompatibleStateImageBehavior = false;
            this.CompletedDeliveryListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DeliveryID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "OrderID";
            this.columnHeader5.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Author";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Warehouse Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.PendingDeliveryTabPage.ResumeLayout(false);
            this.CompletedDeliveryTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PendingDeliveryTabPage;
        private System.Windows.Forms.TabPage CompletedDeliveryTabPage;
        private System.Windows.Forms.ListView PendentDeliveryListView;
        private System.Windows.Forms.Button CompleteDeliveryButton;
        private System.Windows.Forms.ColumnHeader bookTitle;
        private System.Windows.Forms.ColumnHeader bookAuthor;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ListView CompletedDeliveryListView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader deliveryID;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader orderID;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}