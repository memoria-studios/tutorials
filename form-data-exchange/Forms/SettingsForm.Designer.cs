namespace FormDataExchange
{
    partial class SettingsForm
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
            labelAppName = new Label();
            comboBoxTheme = new ComboBox();
            label2 = new Label();
            buttonConfirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 30);
            label1.Name = "label1";
            label1.Size = new Size(188, 15);
            label1.TabIndex = 0;
            label1.Text = "You have selected this application:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelAppName
            // 
            labelAppName.AutoSize = true;
            labelAppName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAppName.Location = new Point(205, 30);
            labelAppName.Name = "labelAppName";
            labelAppName.Size = new Size(109, 15);
            labelAppName.TabIndex = 1;
            labelAppName.Text = "{application.name}";
            // 
            // comboBoxTheme
            // 
            comboBoxTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTheme.FlatStyle = FlatStyle.Flat;
            comboBoxTheme.FormattingEnabled = true;
            comboBoxTheme.Items.AddRange(new object[] { "System (default)", "Light", "Dark" });
            comboBoxTheme.Location = new Point(92, 120);
            comboBoxTheme.Name = "comboBoxTheme";
            comboBoxTheme.Size = new Size(147, 23);
            comboBoxTheme.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 102);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Theme";
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(119, 172);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(80, 23);
            buttonConfirm.TabIndex = 4;
            buttonConfirm.Text = "OK";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 219);
            Controls.Add(buttonConfirm);
            Controls.Add(label2);
            Controls.Add(comboBoxTheme);
            Controls.Add(labelAppName);
            Controls.Add(label1);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            Activated += SettingsForm_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelAppName;
        private ComboBox comboBoxTheme;
        private Label label2;
        private Button buttonConfirm;
    }
}