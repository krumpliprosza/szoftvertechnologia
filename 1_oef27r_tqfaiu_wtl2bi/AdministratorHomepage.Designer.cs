namespace _1_oef27r_tqfaiu_wtl2bi
{
    partial class AdministratorHomepage
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
            menuStrip1 = new MenuStrip();
            OrderCreate = new ToolStripMenuItem();
            StorageQuery = new ToolStripMenuItem();
            ServiceQuery = new ToolStripMenuItem();
            OrdersToSendDataGrid = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColName = new DataGridViewTextBoxColumn();
            ColLicNo = new DataGridViewTextBoxColumn();
            ColTotalPrice = new DataGridViewTextBoxColumn();
            ReadyOrders = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnLicNo = new DataGridViewTextBoxColumn();
            ColumnTotalPrice = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersToSendDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReadyOrders).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { OrderCreate, StorageQuery, ServiceQuery });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(941, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // OrderCreate
            // 
            OrderCreate.Name = "OrderCreate";
            OrderCreate.Size = new Size(113, 20);
            OrderCreate.Text = "Rendelés felvétele";
            OrderCreate.Click += OrderCreate_Click;
            // 
            // StorageQuery
            // 
            StorageQuery.Name = "StorageQuery";
            StorageQuery.Size = new Size(159, 20);
            StorageQuery.Text = "Termék rendeléshez kötése";
            StorageQuery.Click += StorageQuery_Click;
            // 
            // ServiceQuery
            // 
            ServiceQuery.Name = "ServiceQuery";
            ServiceQuery.Size = new Size(183, 20);
            ServiceQuery.Text = "Szolgáltatás rendeléshez kötése";
            ServiceQuery.Click += ServiceQuery_Click;
            // 
            // OrdersToSendDataGrid
            // 
            OrdersToSendDataGrid.AllowUserToAddRows = false;
            OrdersToSendDataGrid.AllowUserToDeleteRows = false;
            OrdersToSendDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersToSendDataGrid.Columns.AddRange(new DataGridViewColumn[] { ColId, ColName, ColLicNo, ColTotalPrice });
            OrdersToSendDataGrid.Location = new Point(12, 27);
            OrdersToSendDataGrid.Name = "OrdersToSendDataGrid";
            OrdersToSendDataGrid.Size = new Size(456, 403);
            OrdersToSendDataGrid.TabIndex = 130;
            OrdersToSendDataGrid.SelectionChanged += OrdersToSendDataGrid_SelectionChanged;
            // 
            // ColId
            // 
            ColId.HeaderText = "Azonosító";
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            // 
            // ColName
            // 
            ColName.HeaderText = "Vásárló neve";
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            // 
            // ColLicNo
            // 
            ColLicNo.HeaderText = "Rendszám";
            ColLicNo.Name = "ColLicNo";
            ColLicNo.ReadOnly = true;
            // 
            // ColTotalPrice
            // 
            ColTotalPrice.HeaderText = "Végösszeg";
            ColTotalPrice.Name = "ColTotalPrice";
            ColTotalPrice.ReadOnly = true;
            // 
            // ReadyOrders
            // 
            ReadyOrders.AllowUserToAddRows = false;
            ReadyOrders.AllowUserToDeleteRows = false;
            ReadyOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReadyOrders.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnName, ColumnLicNo, ColumnTotalPrice });
            ReadyOrders.Location = new Point(474, 27);
            ReadyOrders.Name = "ReadyOrders";
            ReadyOrders.Size = new Size(456, 403);
            ReadyOrders.TabIndex = 131;
            ReadyOrders.SelectionChanged += ReadyOrders_SelectionChanged;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Azonosító";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Vásárló neve";
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            // 
            // ColumnLicNo
            // 
            ColumnLicNo.HeaderText = "Rendszám";
            ColumnLicNo.Name = "ColumnLicNo";
            ColumnLicNo.ReadOnly = true;
            // 
            // ColumnTotalPrice
            // 
            ColumnTotalPrice.HeaderText = "Végösszeg";
            ColumnTotalPrice.Name = "ColumnTotalPrice";
            ColumnTotalPrice.ReadOnly = true;
            // 
            // AdministratorHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 450);
            Controls.Add(ReadyOrders);
            Controls.Add(OrdersToSendDataGrid);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdministratorHomepage";
            Text = "Kezdőlap";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersToSendDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReadyOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem StorageQuery;
        private ToolStripMenuItem OrderCreate;
        private ToolStripMenuItem ServiceQuery;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridView OrdersToSendDataGrid;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColLicNo;
        private DataGridViewTextBoxColumn ColTotalPrice;
        private DataGridView ReadyOrders;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLicNo;
        private DataGridViewTextBoxColumn ColumnTotalPrice;
    }
}