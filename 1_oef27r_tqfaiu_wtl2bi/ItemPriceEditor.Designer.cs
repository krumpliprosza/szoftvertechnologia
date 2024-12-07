namespace _1_oef27r_tqfaiu_wtl2bi
{
    partial class ItemPriceEditor
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            idTB = new TextBox();
            brandTB = new TextBox();
            nameTB = new TextBox();
            priceTB = new TextBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(28, 37);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Azonosító";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(28, 85);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Márka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(28, 138);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 2;
            label3.Text = "Név";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(28, 192);
            label4.Name = "label4";
            label4.Size = new Size(24, 20);
            label4.TabIndex = 3;
            label4.Text = "Ár";
            // 
            // idTB
            // 
            idTB.Location = new Point(113, 34);
            idTB.Name = "idTB";
            idTB.Size = new Size(134, 23);
            idTB.TabIndex = 4;
            // 
            // brandTB
            // 
            brandTB.Location = new Point(113, 82);
            brandTB.Name = "brandTB";
            brandTB.Size = new Size(134, 23);
            brandTB.TabIndex = 4;
            // 
            // nameTB
            // 
            nameTB.Location = new Point(113, 135);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(134, 23);
            nameTB.TabIndex = 4;
            // 
            // priceTB
            // 
            priceTB.Location = new Point(113, 189);
            priceTB.Name = "priceTB";
            priceTB.Size = new Size(134, 23);
            priceTB.TabIndex = 4;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(28, 232);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(219, 63);
            saveButton.TabIndex = 5;
            saveButton.Text = "Módosítások mentése";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // ItemPriceEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 347);
            Controls.Add(saveButton);
            Controls.Add(priceTB);
            Controls.Add(nameTB);
            Controls.Add(brandTB);
            Controls.Add(idTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ItemPriceEditor";
            Text = "Termék árak szerkesztése";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox idTB;
        private TextBox brandTB;
        private TextBox nameTB;
        private TextBox priceTB;
        private Button saveButton;
    }
}