namespace _1_oef27r_tqfaiu_wtl2bi
{
    partial class LowStock
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
            lowStockDataGrid = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colBrand = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)lowStockDataGrid).BeginInit();
            SuspendLayout();
            // 
            // lowStockDataGrid
            // 
            lowStockDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lowStockDataGrid.Columns.AddRange(new DataGridViewColumn[] { colId, colBrand, colName, colQuantity, colLocation });
            lowStockDataGrid.Location = new Point(-1, 0);
            lowStockDataGrid.Name = "lowStockDataGrid";
            lowStockDataGrid.Size = new Size(801, 450);
            lowStockDataGrid.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "Azonosító";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colBrand
            // 
            colBrand.HeaderText = "Márka";
            colBrand.Name = "colBrand";
            colBrand.ReadOnly = true;
            colBrand.Width = 150;
            // 
            // colName
            // 
            colName.HeaderText = "Név";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 200;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Mennyiség";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colLocation
            // 
            colLocation.HeaderText = "Helyszín";
            colLocation.Name = "colLocation";
            colLocation.ReadOnly = true;
            // 
            // LowStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lowStockDataGrid);
            Name = "LowStock";
            Text = "Alacsony darabszámú termékek listája";
            ((System.ComponentModel.ISupportInitialize)lowStockDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView lowStockDataGrid;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colBrand;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colLocation;
    }
}