namespace _1_oef27r_tqfaiu_wtl2bi
{
    partial class ServicePriceEditor
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
            nameTB = new TextBox();
            basepriceTB = new TextBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Név";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 0;
            label2.Text = "Alapár";
            // 
            // nameTB
            // 
            nameTB.Location = new Point(76, 6);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(100, 23);
            nameTB.TabIndex = 1;
            // 
            // basepriceTB
            // 
            basepriceTB.Location = new Point(76, 52);
            basepriceTB.Name = "basepriceTB";
            basepriceTB.Size = new Size(100, 23);
            basepriceTB.TabIndex = 1;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(131, 126);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(188, 72);
            saveButton.TabIndex = 2;
            saveButton.Text = "Mentés";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // ServicePriceEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 275);
            Controls.Add(saveButton);
            Controls.Add(basepriceTB);
            Controls.Add(nameTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ServicePriceEditor";
            Text = "ServicePriceEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nameTB;
        private TextBox basepriceTB;
        private Button saveButton;
    }
}