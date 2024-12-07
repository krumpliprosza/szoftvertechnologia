namespace _1_oef27r_tqfaiu_wtl2bi
{
    partial class CeoHomepage
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            bejelentkezésiAdatokSzerkesztéseToolStripMenuItem = new ToolStripMenuItem();
            árakSzerkesztéseToolStripMenuItem = new ToolStripMenuItem();
            termékekToolStripMenuItem = new ToolStripMenuItem();
            szolgáltatásokToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            serviceBindingSource = new BindingSource(components);
            workerBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            telno = new DataGridViewTextBoxColumn();
            licenseno = new DataGridViewTextBoxColumn();
            brandName = new DataGridViewTextBoxColumn();
            tyreName = new DataGridViewTextBoxColumn();
            tquantity = new DataGridViewTextBoxColumn();
            sName = new DataGridViewTextBoxColumn();
            squantity = new DataGridViewTextBoxColumn();
            endDate = new DataGridViewTextBoxColumn();
            totalPrice = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { bejelentkezésiAdatokSzerkesztéseToolStripMenuItem, árakSzerkesztéseToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1105, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // bejelentkezésiAdatokSzerkesztéseToolStripMenuItem
            // 
            bejelentkezésiAdatokSzerkesztéseToolStripMenuItem.Name = "bejelentkezésiAdatokSzerkesztéseToolStripMenuItem";
            bejelentkezésiAdatokSzerkesztéseToolStripMenuItem.Size = new Size(197, 20);
            bejelentkezésiAdatokSzerkesztéseToolStripMenuItem.Text = "Bejelentkezési adatok szerkesztése";
            bejelentkezésiAdatokSzerkesztéseToolStripMenuItem.Click += bejelentkezésiAdatokSzerkesztéseToolStripMenuItem_Click;
            // 
            // árakSzerkesztéseToolStripMenuItem
            // 
            árakSzerkesztéseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { termékekToolStripMenuItem, szolgáltatásokToolStripMenuItem });
            árakSzerkesztéseToolStripMenuItem.Name = "árakSzerkesztéseToolStripMenuItem";
            árakSzerkesztéseToolStripMenuItem.Size = new Size(109, 20);
            árakSzerkesztéseToolStripMenuItem.Text = "Árak szerkesztése";
            // 
            // termékekToolStripMenuItem
            // 
            termékekToolStripMenuItem.Name = "termékekToolStripMenuItem";
            termékekToolStripMenuItem.Size = new Size(149, 22);
            termékekToolStripMenuItem.Text = "Termékek";
            termékekToolStripMenuItem.Click += termékekToolStripMenuItem_Click;
            // 
            // szolgáltatásokToolStripMenuItem
            // 
            szolgáltatásokToolStripMenuItem.Name = "szolgáltatásokToolStripMenuItem";
            szolgáltatásokToolStripMenuItem.Size = new Size(149, 22);
            szolgáltatásokToolStripMenuItem.Text = "Szolgáltatások";
            szolgáltatásokToolStripMenuItem.Click += szolgáltatásokToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 2;
            label1.Text = "Az elmúlt 30 nap eladásai";
            // 
            // serviceBindingSource
            // 
            serviceBindingSource.DataSource = typeof(Classes.Service);
            // 
            // workerBindingSource
            // 
            workerBindingSource.DataSource = typeof(Classes.Worker);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, name, telno, licenseno, brandName, tyreName, tquantity, sName, squantity, endDate, totalPrice });
            dataGridView1.Location = new Point(0, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1105, 322);
            dataGridView1.TabIndex = 3;
            // 
            // id
            // 
            id.HeaderText = "Azonosító";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Megrendelő";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // telno
            // 
            telno.HeaderText = "Telefonszám";
            telno.Name = "telno";
            telno.ReadOnly = true;
            // 
            // licenseno
            // 
            licenseno.HeaderText = "Rendszám";
            licenseno.Name = "licenseno";
            licenseno.ReadOnly = true;
            // 
            // brandName
            // 
            brandName.HeaderText = "Márka";
            brandName.Name = "brandName";
            brandName.ReadOnly = true;
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
            endDate.ReadOnly = true;
            // 
            // totalPrice
            // 
            totalPrice.HeaderText = "Teljes ár";
            totalPrice.Name = "totalPrice";
            totalPrice.ReadOnly = true;
            // 
            // CeoHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CeoHomepage";
            Text = "Kezdőlap";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)workerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bejelentkezésiAdatokSzerkesztéseToolStripMenuItem;
        private ToolStripMenuItem árakSzerkesztéseToolStripMenuItem;
        private ToolStripMenuItem termékekToolStripMenuItem;
        private ToolStripMenuItem szolgáltatásokToolStripMenuItem;
        private Label label1;
        private BindingSource serviceBindingSource;
        private BindingSource workerBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn telno;
        private DataGridViewTextBoxColumn licenseno;
        private DataGridViewTextBoxColumn brandName;
        private DataGridViewTextBoxColumn tyreName;
        private DataGridViewTextBoxColumn tquantity;
        private DataGridViewTextBoxColumn sName;
        private DataGridViewTextBoxColumn squantity;
        private DataGridViewTextBoxColumn endDate;
        private DataGridViewTextBoxColumn totalPrice;
    }
}