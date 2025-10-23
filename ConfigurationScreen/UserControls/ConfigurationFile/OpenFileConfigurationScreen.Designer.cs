namespace ConfigurationScreen.UserControls.ConfigurationFile
{
    partial class OpenFileConfigurationScreen
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
            panel2 = new Panel();
            Cancel_btn = new Button();
            Ok_btn = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            comboBox1 = new ComboBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Controls.Add(Cancel_btn);
            panel2.Controls.Add(Ok_btn);
            panel2.Location = new Point(0, 233);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 52);
            panel2.TabIndex = 5;
            // 
            // Cancel_btn
            // 
            Cancel_btn.BackColor = Color.Gainsboro;
            Cancel_btn.FlatStyle = FlatStyle.Popup;
            Cancel_btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Cancel_btn.Location = new Point(264, 10);
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
            Ok_btn.Location = new Point(101, 10);
            Ok_btn.Name = "Ok_btn";
            Ok_btn.Size = new Size(82, 30);
            Ok_btn.TabIndex = 2;
            Ok_btn.Text = "OK";
            Ok_btn.UseVisualStyleBackColor = false;
            Ok_btn.Click += Ok_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 52);
            panel1.TabIndex = 4;
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
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(37, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(380, 56);
            panel3.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(72, 13);
            label2.Name = "label2";
            label2.Size = new Size(243, 28);
            label2.TabIndex = 2;
            label2.Text = "Select the Configuration";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 13F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(67, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(319, 31);
            comboBox1.TabIndex = 9;
            // 
            // OpenFileConfigurationScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "OpenFileConfigurationScreen";
            Size = new Size(460, 285);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button Cancel_btn;
        private Button Ok_btn;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private ComboBox comboBox1;
    }
}
