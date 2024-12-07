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
            menuStrip1 = new MenuStrip();
            bejelentkezésiAdatokSzerkesztéseToolStripMenuItem = new ToolStripMenuItem();
            árakSzerkesztéseToolStripMenuItem = new ToolStripMenuItem();
            termékekToolStripMenuItem = new ToolStripMenuItem();
            szolgáltatásokToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { bejelentkezésiAdatokSzerkesztéseToolStripMenuItem, árakSzerkesztéseToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
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
            termékekToolStripMenuItem.Size = new Size(180, 22);
            termékekToolStripMenuItem.Text = "Termékek";
            termékekToolStripMenuItem.Click += termékekToolStripMenuItem_Click;
            // 
            // szolgáltatásokToolStripMenuItem
            // 
            szolgáltatásokToolStripMenuItem.Name = "szolgáltatásokToolStripMenuItem";
            szolgáltatásokToolStripMenuItem.Size = new Size(180, 22);
            szolgáltatásokToolStripMenuItem.Text = "Szolgáltatások";
            // 
            // CeoHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CeoHomepage";
            Text = "Kezdőlap";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bejelentkezésiAdatokSzerkesztéseToolStripMenuItem;
        private ToolStripMenuItem árakSzerkesztéseToolStripMenuItem;
        private ToolStripMenuItem termékekToolStripMenuItem;
        private ToolStripMenuItem szolgáltatásokToolStripMenuItem;
    }
}