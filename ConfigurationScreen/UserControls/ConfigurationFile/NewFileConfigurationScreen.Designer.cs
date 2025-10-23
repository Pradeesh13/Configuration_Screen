namespace ConfigurationScreen.UserControls.ConfigurationFile
{
    partial class NewFileConfigurationScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            Cancel_btn = new Button();
            Ok_btn = new Button();
            InputText_txtbox = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 52);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(166, 12);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 2;
            label1.Text = "USER INPUT";
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Controls.Add(Cancel_btn);
            panel2.Controls.Add(Ok_btn);
            panel2.Location = new Point(0, 233);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 52);
            panel2.TabIndex = 1;
            // 
            // Cancel_btn
            // 
            Cancel_btn.BackColor = Color.Gainsboro;
            Cancel_btn.FlatStyle = FlatStyle.Popup;
            Cancel_btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Cancel_btn.Location = new Point(263, 10);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(82, 30);
            Cancel_btn.TabIndex = 2;
            Cancel_btn.Text = "CANCEL";
            Cancel_btn.UseVisualStyleBackColor = false;
            // 
            // Ok_btn
            // 
            Ok_btn.BackColor = Color.Gainsboro;
            Ok_btn.FlatStyle = FlatStyle.Popup;
            Ok_btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Ok_btn.Location = new Point(102, 10);
            Ok_btn.Name = "Ok_btn";
            Ok_btn.Size = new Size(82, 30);
            Ok_btn.TabIndex = 2;
            Ok_btn.Text = "OK";
            Ok_btn.UseVisualStyleBackColor = false;
            Ok_btn.Click += Ok_btn_Click;
            // 
            // InputText_txtbox
            // 
            InputText_txtbox.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            InputText_txtbox.Location = new Point(37, 170);
            InputText_txtbox.Name = "InputText_txtbox";
            InputText_txtbox.Size = new Size(380, 31);
            InputText_txtbox.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(37, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(380, 56);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(39, 13);
            label2.Name = "label2";
            label2.Size = new Size(298, 28);
            label2.TabIndex = 2;
            label2.Text = "Enter the Configuration Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(38, 141);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 2;
            label3.Text = "Input Text";
            // 
            // NewFileConfigurationScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(InputText_txtbox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "NewFileConfigurationScreen";
            Size = new Size(460, 285);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button Ok_btn;
        private Button Cancel_btn;
        private TextBox InputText_txtbox;
        private Panel panel3;
        private Label label2;
        private Label label3;
    }
}
