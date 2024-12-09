namespace _1_oef27r_tqfaiu_wtl2bi
{
    partial class EditPage
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
            roleBox = new TextBox();
            label2 = new Label();
            passwordBox = new TextBox();
            label3 = new Label();
            usernameBox = new TextBox();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 0;
            label1.Text = "Felhasználónév";
            // 
            // roleBox
            // 
            roleBox.Location = new Point(149, 100);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(100, 23);
            roleBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 2;
            label2.Text = "Jelszó";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(149, 58);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(100, 23);
            passwordBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 4;
            label3.Text = "Beosztás";
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(149, 17);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(100, 23);
            usernameBox.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(12, 147);
            button1.Name = "button1";
            button1.Size = new Size(237, 58);
            button1.TabIndex = 6;
            button1.Text = "Mentés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 108);
            label4.Name = "label4";
            label4.Size = new Size(210, 15);
            label4.TabIndex = 7;
            label4.Text = "1 - ügyintéző / 2 - raktáros / 3 - szerelő";
            // 
            // EditPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 220);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(usernameBox);
            Controls.Add(label3);
            Controls.Add(passwordBox);
            Controls.Add(label2);
            Controls.Add(roleBox);
            Controls.Add(label1);
            Name = "EditPage";
            Text = "Felhasználói adatok szerkesztése";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox roleBox;
        private Label label2;
        private TextBox passwordBox;
        private Label label3;
        private TextBox usernameBox;
        private Button button1;
        private Label label4;
    }
}