namespace _1_oef27r_tqfaiu_wtl2bi
{
    partial class WorkshopHomePage
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
            dataGridView1 = new DataGridView();
            licenseNo = new DataGridViewTextBoxColumn();
            brand = new DataGridViewTextBoxColumn();
            tyreName = new DataGridViewTextBoxColumn();
            tquantity = new DataGridViewTextBoxColumn();
            sName = new DataGridViewTextBoxColumn();
            squantity = new DataGridViewTextBoxColumn();
            endDate = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { licenseNo, brand, tyreName, tquantity, sName, squantity, endDate, status });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(905, 450);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView1.KeyDown += WorkshopHomePage_KeyDown;
            // 
            // licenseNo
            // 
            licenseNo.HeaderText = "Rendszám";
            licenseNo.Name = "licenseNo";
            licenseNo.ReadOnly = true;
            // 
            // brand
            // 
            brand.HeaderText = "Márka";
            brand.Name = "brand";
            brand.ReadOnly = true;
            // 
            // tyreName
            // 
            tyreName.HeaderText = "Név";
            tyreName.Name = "tyreName";
            tyreName.ReadOnly = true;
            // 
            // tquantity
            // 
            tquantity.HeaderText = "Mennyiség";
            tquantity.Name = "tquantity";
            tquantity.ReadOnly = true;
            // 
            // sName
            // 
            sName.HeaderText = "Szolgáltatás neve";
            sName.Name = "sName";
            sName.ReadOnly = true;
            sName.Width = 130;
            // 
            // squantity
            // 
            squantity.HeaderText = "Mennyiség";
            squantity.Name = "squantity";
            squantity.ReadOnly = true;
            // 
            // endDate
            // 
            endDate.HeaderText = "Befejezési dátum";
            endDate.Name = "endDate";
            endDate.Width = 130;
            // 
            // status
            // 
            status.HeaderText = "Státusz";
            status.Name = "status";
            // 
            // WorkshopHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 450);
            Controls.Add(dataGridView1);
            Name = "WorkshopHomePage";
            Text = "Kezdőlap";
            Load += WorkshopHomePage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn licenseNo;
        private DataGridViewTextBoxColumn brand;
        private DataGridViewTextBoxColumn tyreName;
        private DataGridViewTextBoxColumn tquantity;
        private DataGridViewTextBoxColumn sName;
        private DataGridViewTextBoxColumn squantity;
        private DataGridViewTextBoxColumn endDate;
        private DataGridViewTextBoxColumn status;
    }
}