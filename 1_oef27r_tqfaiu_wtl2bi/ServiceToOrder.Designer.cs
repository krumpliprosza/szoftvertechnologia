namespace _1_oef27r_tqfaiu_wtl2bi
{
    partial class ServiceToOrder
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
            OrderQuantityValue = new TextBox();
            OrderQuantityLabel = new Label();
            OrderDataGrid = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColName = new DataGridViewTextBoxColumn();
            ColLicenseNumber = new DataGridViewTextBoxColumn();
            NameValue = new TextBox();
            NameLabel = new Label();
            BasePriceValue = new TextBox();
            BasePriceLabel = new Label();
            DiameterValue = new TextBox();
            DiameterLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)OrderDataGrid).BeginInit();
            SuspendLayout();
            // 
            // OrderQuantityValue
            // 
            OrderQuantityValue.Location = new Point(107, 66);
            OrderQuantityValue.Name = "OrderQuantityValue";
            OrderQuantityValue.Size = new Size(100, 23);
            OrderQuantityValue.TabIndex = 129;
            // 
            // OrderQuantityLabel
            // 
            OrderQuantityLabel.AutoSize = true;
            OrderQuantityLabel.Location = new Point(13, 66);
            OrderQuantityLabel.Name = "OrderQuantityLabel";
            OrderQuantityLabel.Size = new Size(65, 15);
            OrderQuantityLabel.TabIndex = 128;
            OrderQuantityLabel.Text = "Mennyiség";
            // 
            // OrderDataGrid
            // 
            OrderDataGrid.AllowUserToAddRows = false;
            OrderDataGrid.AllowUserToDeleteRows = false;
            OrderDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderDataGrid.Columns.AddRange(new DataGridViewColumn[] { ColId, ColName, ColLicenseNumber });
            OrderDataGrid.Location = new Point(227, 12);
            OrderDataGrid.Name = "OrderDataGrid";
            OrderDataGrid.Size = new Size(256, 371);
            OrderDataGrid.TabIndex = 127;
            OrderDataGrid.SelectionChanged += OrderDataGrid_SelectionChanged;
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
            // ColLicenseNumber
            // 
            ColLicenseNumber.HeaderText = "Rendszám";
            ColLicenseNumber.Name = "ColLicenseNumber";
            ColLicenseNumber.ReadOnly = true;
            // 
            // NameValue
            // 
            NameValue.Location = new Point(107, 12);
            NameValue.Name = "NameValue";
            NameValue.ReadOnly = true;
            NameValue.Size = new Size(100, 23);
            NameValue.TabIndex = 126;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(13, 12);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(66, 15);
            NameLabel.TabIndex = 125;
            NameLabel.Text = "Szolg. neve";
            // 
            // BasePriceValue
            // 
            BasePriceValue.Location = new Point(107, 39);
            BasePriceValue.Name = "BasePriceValue";
            BasePriceValue.ReadOnly = true;
            BasePriceValue.Size = new Size(100, 23);
            BasePriceValue.TabIndex = 107;
            // 
            // BasePriceLabel
            // 
            BasePriceLabel.AutoSize = true;
            BasePriceLabel.Location = new Point(13, 39);
            BasePriceLabel.Name = "BasePriceLabel";
            BasePriceLabel.Size = new Size(41, 15);
            BasePriceLabel.TabIndex = 95;
            BasePriceLabel.Text = "Alapár";
            // 
            // DiameterValue
            // 
            DiameterValue.Location = new Point(107, 93);
            DiameterValue.Name = "DiameterValue";
            DiameterValue.Size = new Size(100, 23);
            DiameterValue.TabIndex = 131;
            // 
            // DiameterLabel
            // 
            DiameterLabel.AutoSize = true;
            DiameterLabel.Location = new Point(13, 93);
            DiameterLabel.Name = "DiameterLabel";
            DiameterLabel.Size = new Size(47, 15);
            DiameterLabel.TabIndex = 130;
            DiameterLabel.Text = "Átmérő";
            // 
            // ServiceToOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 395);
            Controls.Add(DiameterValue);
            Controls.Add(DiameterLabel);
            Controls.Add(OrderQuantityValue);
            Controls.Add(OrderQuantityLabel);
            Controls.Add(OrderDataGrid);
            Controls.Add(NameValue);
            Controls.Add(NameLabel);
            Controls.Add(BasePriceValue);
            Controls.Add(BasePriceLabel);
            Name = "ServiceToOrder";
            Text = "Szolgáltatás igénylése";
            ((System.ComponentModel.ISupportInitialize)OrderDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OrderQuantityInput;
        private Label OrderQuantityLabel;
        private DataGridView OrderDataGrid;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColLicenseNumber;
        private TextBox IdValue;
        private Label IdLabel;
        private TextBox BrandValue;
        private Label brandLabel;
        private TextBox textBox1;
        private Label label1;
        private TextBox OrderQuantityValue;
        private TextBox DiameterValue;
        private Label DiameterLabel;
        private TextBox NameValue;
        private Label NameLabel;
        private TextBox BasePriceValue;
        private Label BasePriceLabel;
    }
}