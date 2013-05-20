namespace StoreApp
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MakeSaleButton = new System.Windows.Forms.Button();
            this.StoreStockListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AcceptDeliveryButton = new System.Windows.Forms.Button();
            this.WaitingDeliveryListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.CompletedDeliveryListView = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.WaitingOrderListView = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompletedOrderListView = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MakeSaleButton);
            this.tabPage1.Controls.Add(this.StoreStockListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(779, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Store Stock";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MakeSaleButton
            // 
            this.MakeSaleButton.Location = new System.Drawing.Point(651, 7);
            this.MakeSaleButton.Name = "MakeSaleButton";
            this.MakeSaleButton.Size = new System.Drawing.Size(117, 29);
            this.MakeSaleButton.TabIndex = 1;
            this.MakeSaleButton.Text = "Sell";
            this.MakeSaleButton.UseVisualStyleBackColor = true;
            this.MakeSaleButton.Click += new System.EventHandler(this.MakeSaleButton_Click);
            // 
            // StoreStockListView
            // 
            this.StoreStockListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader27,
            this.columnHeader4});
            this.StoreStockListView.FullRowSelect = true;
            this.StoreStockListView.GridLines = true;
            this.StoreStockListView.Location = new System.Drawing.Point(8, 42);
            this.StoreStockListView.MultiSelect = false;
            this.StoreStockListView.Name = "StoreStockListView";
            this.StoreStockListView.Size = new System.Drawing.Size(760, 485);
            this.StoreStockListView.TabIndex = 0;
            this.StoreStockListView.UseCompatibleStateImageBehavior = false;
            this.StoreStockListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "BookID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Author";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stock";
            this.columnHeader4.Width = 100;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AcceptDeliveryButton);
            this.tabPage2.Controls.Add(this.WaitingDeliveryListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(779, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Waiting Deliveries";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AcceptDeliveryButton
            // 
            this.AcceptDeliveryButton.Location = new System.Drawing.Point(651, 7);
            this.AcceptDeliveryButton.Name = "AcceptDeliveryButton";
            this.AcceptDeliveryButton.Size = new System.Drawing.Size(117, 29);
            this.AcceptDeliveryButton.TabIndex = 2;
            this.AcceptDeliveryButton.Text = "Accept Delivery";
            this.AcceptDeliveryButton.UseVisualStyleBackColor = true;
            this.AcceptDeliveryButton.Click += new System.EventHandler(this.AcceptDeliveryButton_Click);
            // 
            // WaitingDeliveryListView
            // 
            this.WaitingDeliveryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader9,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.WaitingDeliveryListView.FullRowSelect = true;
            this.WaitingDeliveryListView.GridLines = true;
            this.WaitingDeliveryListView.Location = new System.Drawing.Point(8, 42);
            this.WaitingDeliveryListView.MultiSelect = false;
            this.WaitingDeliveryListView.Name = "WaitingDeliveryListView";
            this.WaitingDeliveryListView.Size = new System.Drawing.Size(760, 485);
            this.WaitingDeliveryListView.TabIndex = 1;
            this.WaitingDeliveryListView.UseCompatibleStateImageBehavior = false;
            this.WaitingDeliveryListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "DeliveryID";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Original Order";
            this.columnHeader9.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Title";
            this.columnHeader6.Width = 250;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Author";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Quantity";
            this.columnHeader8.Width = 150;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.CompletedDeliveryListView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(779, 537);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Completed Deliveries";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // CompletedDeliveryListView
            // 
            this.CompletedDeliveryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.CompletedDeliveryListView.FullRowSelect = true;
            this.CompletedDeliveryListView.GridLines = true;
            this.CompletedDeliveryListView.Location = new System.Drawing.Point(8, 10);
            this.CompletedDeliveryListView.Name = "CompletedDeliveryListView";
            this.CompletedDeliveryListView.Size = new System.Drawing.Size(760, 517);
            this.CompletedDeliveryListView.TabIndex = 2;
            this.CompletedDeliveryListView.UseCompatibleStateImageBehavior = false;
            this.CompletedDeliveryListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "DeliveryID";
            this.columnHeader10.Width = 0;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Original Order";
            this.columnHeader11.Width = 200;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Title";
            this.columnHeader12.Width = 250;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Author";
            this.columnHeader13.Width = 150;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Quantity";
            this.columnHeader14.Width = 150;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.WaitingOrderListView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(779, 537);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Waiting Orders";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // WaitingOrderListView
            // 
            this.WaitingOrderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader25,
            this.columnHeader28,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.WaitingOrderListView.FullRowSelect = true;
            this.WaitingOrderListView.GridLines = true;
            this.WaitingOrderListView.Location = new System.Drawing.Point(8, 10);
            this.WaitingOrderListView.Name = "WaitingOrderListView";
            this.WaitingOrderListView.Size = new System.Drawing.Size(760, 517);
            this.WaitingOrderListView.TabIndex = 3;
            this.WaitingOrderListView.UseCompatibleStateImageBehavior = false;
            this.WaitingOrderListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Order ID";
            this.columnHeader16.Width = 120;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "State";
            this.columnHeader25.Width = 100;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Title";
            this.columnHeader17.Width = 150;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Client Email";
            this.columnHeader18.Width = 150;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Quantity";
            this.columnHeader19.Width = 50;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Total Price";
            this.columnHeader20.Width = 80;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.CompletedOrderListView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(779, 537);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Completed Orders";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Price";
            this.columnHeader27.Width = 100;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Dispatch Date";
            this.columnHeader28.Width = 100;
            // 
            // CompletedOrderListView
            // 
            this.CompletedOrderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader26,
            this.columnHeader29});
            this.CompletedOrderListView.FullRowSelect = true;
            this.CompletedOrderListView.GridLines = true;
            this.CompletedOrderListView.Location = new System.Drawing.Point(8, 10);
            this.CompletedOrderListView.Name = "CompletedOrderListView";
            this.CompletedOrderListView.Size = new System.Drawing.Size(760, 517);
            this.CompletedOrderListView.TabIndex = 4;
            this.CompletedOrderListView.UseCompatibleStateImageBehavior = false;
            this.CompletedOrderListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Order ID";
            this.columnHeader15.Width = 120;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "State";
            this.columnHeader21.Width = 100;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Dispatch Date";
            this.columnHeader22.Width = 100;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Title";
            this.columnHeader23.Width = 150;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Client Email";
            this.columnHeader24.Width = 150;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Quantity";
            this.columnHeader26.Width = 50;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Total Price";
            this.columnHeader29.Width = 80;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Store Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView StoreStockListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button MakeSaleButton;
        private System.Windows.Forms.Button AcceptDeliveryButton;
        private System.Windows.Forms.ListView WaitingDeliveryListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView CompletedDeliveryListView;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ListView WaitingOrderListView;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ListView CompletedOrderListView;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader29;



    }
}