namespace _1_oef27r_tqfaiu_wtl2bi
{
    partial class ServiceAdd
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
            ServiceDataGrid = new DataGridView();
            ColName = new DataGridViewTextBoxColumn();
            ColBasePrice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ServiceDataGrid).BeginInit();
            SuspendLayout();
            // 
            // ServiceDataGrid
            // 
            ServiceDataGrid.AllowUserToAddRows = false;
            ServiceDataGrid.AllowUserToDeleteRows = false;
            ServiceDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceDataGrid.Columns.AddRange(new DataGridViewColumn[] { ColName, ColBasePrice });
            ServiceDataGrid.Location = new Point(12, 12);
            ServiceDataGrid.Name = "ServiceDataGrid";
            ServiceDataGrid.ReadOnly = true;
            ServiceDataGrid.Size = new Size(375, 264);
            ServiceDataGrid.TabIndex = 0;
            ServiceDataGrid.SelectionChanged += ServiceDataGrid_SelectionChanged;
            // 
            // ColName
            // 
            ColName.HeaderText = "Szolgáltatás neve";
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            // 
            // ColBasePrice
            // 
            ColBasePrice.HeaderText = "Alapár";
            ColBasePrice.Name = "ColBasePrice";
            ColBasePrice.ReadOnly = true;
            // 
            // ServiceAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 289);
            Controls.Add(ServiceDataGrid);
            Name = "ServiceAdd";
            Text = "Szolgáltatás keresése";
            ((System.ComponentModel.ISupportInitialize)ServiceDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ServiceDataGrid;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColBasePrice;
    }
}