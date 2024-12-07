namespace _1_oef27r_tqfaiu_wtl2bi
{
    partial class OrderAdd
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
            OrderMake = new Button();
            NameInput = new TextBox();
            profileRatioLabel = new Label();
            profileWidthLabel = new Label();
            seasonLabel = new Label();
            nameLabel = new Label();
            TelNoInput = new TextBox();
            LicNoInput = new TextBox();
            EndDateInput = new DateTimePicker();
            SuspendLayout();
            // 
            // OrderMake
            // 
            OrderMake.Location = new Point(333, 81);
            OrderMake.Name = "OrderMake";
            OrderMake.Size = new Size(112, 43);
            OrderMake.TabIndex = 120;
            OrderMake.Text = "Küldés";
            OrderMake.UseVisualStyleBackColor = true;
            OrderMake.Click += OrderMake_Click;
            // 
            // NameInput
            // 
            NameInput.Location = new Point(112, 20);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(100, 23);
            NameInput.TabIndex = 115;
            // 
            // profileRatioLabel
            // 
            profileRatioLabel.AutoSize = true;
            profileRatioLabel.Location = new Point(18, 101);
            profileRatioLabel.Name = "profileRatioLabel";
            profileRatioLabel.Size = new Size(79, 15);
            profileRatioLabel.TabIndex = 106;
            profileRatioLabel.Text = "Várh. bef. dát.";
            // 
            // profileWidthLabel
            // 
            profileWidthLabel.AutoSize = true;
            profileWidthLabel.Location = new Point(18, 74);
            profileWidthLabel.Name = "profileWidthLabel";
            profileWidthLabel.Size = new Size(61, 15);
            profileWidthLabel.TabIndex = 105;
            profileWidthLabel.Text = "Rendszám";
            // 
            // seasonLabel
            // 
            seasonLabel.AutoSize = true;
            seasonLabel.Location = new Point(18, 47);
            seasonLabel.Name = "seasonLabel";
            seasonLabel.Size = new Size(72, 15);
            seasonLabel.TabIndex = 104;
            seasonLabel.Text = "Telefonszám";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(18, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(28, 15);
            nameLabel.TabIndex = 103;
            nameLabel.Text = "Név";
            // 
            // TelNoInput
            // 
            TelNoInput.Location = new Point(112, 47);
            TelNoInput.Name = "TelNoInput";
            TelNoInput.Size = new Size(100, 23);
            TelNoInput.TabIndex = 124;
            // 
            // LicNoInput
            // 
            LicNoInput.Location = new Point(112, 74);
            LicNoInput.Name = "LicNoInput";
            LicNoInput.Size = new Size(100, 23);
            LicNoInput.TabIndex = 125;
            // 
            // EndDateInput
            // 
            EndDateInput.Location = new Point(112, 101);
            EndDateInput.Name = "EndDateInput";
            EndDateInput.Size = new Size(200, 23);
            EndDateInput.TabIndex = 127;
            EndDateInput.Value = new DateTime(2024, 12, 7, 18, 58, 10, 0);
            // 
            // OrderAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 144);
            Controls.Add(EndDateInput);
            Controls.Add(LicNoInput);
            Controls.Add(TelNoInput);
            Controls.Add(OrderMake);
            Controls.Add(NameInput);
            Controls.Add(profileRatioLabel);
            Controls.Add(profileWidthLabel);
            Controls.Add(seasonLabel);
            Controls.Add(nameLabel);
            Name = "OrderAdd";
            Text = "OrderAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button OrderMake;
        private TextBox NameInput;
        private Label profileRatioLabel;
        private Label profileWidthLabel;
        private Label seasonLabel;
        private Label nameLabel;
        private TextBox TelNoInput;
        private TextBox LicNoInput;
        private DateTimePicker EndDateInput;
    }
}