namespace _1_oef27r_tqfaiu_wtl2bi
{
    partial class StorageWorkerHomepage
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
            menuStrip = new MenuStrip();
            lowStock = new ToolStripMenuItem();
            storageQuery = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { lowStock, storageQuery });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "Menü";
            // 
            // lowStock
            // 
            lowStock.Name = "lowStock";
            lowStock.Size = new Size(186, 20);
            lowStock.Text = "Alacsony darabszámú termékek";
            lowStock.Click += LowStock_Click;
            // 
            // storageQuery
            // 
            storageQuery.Name = "storageQuery";
            storageQuery.Size = new Size(58, 20);
            storageQuery.Text = "Keresés";
            storageQuery.Click += storageQuery_Click;
            // 
            // StorageWorkerHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "StorageWorkerHomepage";
            Text = "Kezdőlap - raktáros";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem lowStock;
        private ToolStripMenuItem storageQuery;
    }
}