namespace FormDataExchange
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonConfirm = new Button();
            comboBoxApp = new ComboBox();
            textBoxTheme = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 111);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Application";
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(178, 219);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(75, 23);
            buttonConfirm.TabIndex = 2;
            buttonConfirm.Text = "OK";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // comboBoxApp
            // 
            comboBoxApp.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxApp.FormattingEnabled = true;
            comboBoxApp.Items.AddRange(new object[] { "Visual Studio", "Telegram", "Steam", "Notion", "Obsidian", "Aseprite", "Chrome" });
            comboBoxApp.Location = new Point(152, 129);
            comboBoxApp.Name = "comboBoxApp";
            comboBoxApp.Size = new Size(121, 23);
            comboBoxApp.TabIndex = 3;
            // 
            // textBoxTheme
            // 
            textBoxTheme.Location = new Point(152, 174);
            textBoxTheme.Name = "textBoxTheme";
            textBoxTheme.ReadOnly = true;
            textBoxTheme.Size = new Size(120, 23);
            textBoxTheme.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 156);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Theme";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 317);
            Controls.Add(label2);
            Controls.Add(textBoxTheme);
            Controls.Add(comboBoxApp);
            Controls.Add(buttonConfirm);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Data Exchange (Main Form)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button buttonConfirm;
        private ComboBox comboBoxApp;
        private TextBox textBoxTheme;
        private Label label2;
    }
}
