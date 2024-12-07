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
            StorageQuery = new ToolStripMenuItem();
            OrderCreate = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { OrderCreate, StorageQuery });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // StorageQuery
            // 
            StorageQuery.Name = "StorageQuery";
            StorageQuery.Size = new Size(159, 20);
            StorageQuery.Text = "Termék rendeléshez kötése";
            StorageQuery.Click += StorageQuery_Click;
            // 
            // OrderCreate
            // 
            OrderCreate.Name = "OrderCreate";
            OrderCreate.Size = new Size(113, 20);
            OrderCreate.Text = "Rendelés felvétele";
            // 
            // AdministratorHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdministratorHomepage";
            Text = "Kezdőlap";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem StorageQuery;
        private ToolStripMenuItem OrderCreate;
    }
}