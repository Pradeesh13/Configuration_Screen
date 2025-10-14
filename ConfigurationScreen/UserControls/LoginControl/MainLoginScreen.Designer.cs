namespace ConfigurationScreen.UserControls.LoginControl
{
    partial class MainLoginScreen
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Login_btn = new Button();
            Cancel_btn = new Button();
            Exit_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(20, 91);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 0;
            label1.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(66, 39);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 0;
            label2.Text = "User :";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.ForeColor = Color.Firebrick;
            textBox1.Location = new Point(134, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 32);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.ForeColor = Color.Firebrick;
            textBox2.Location = new Point(134, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 32);
            textBox2.TabIndex = 1;
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.IndianRed;
            Login_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Login_btn.ForeColor = Color.WhiteSmoke;
            Login_btn.Location = new Point(24, 147);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(87, 31);
            Login_btn.TabIndex = 2;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = false;
            // 
            // Cancel_btn
            // 
            Cancel_btn.BackColor = Color.IndianRed;
            Cancel_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Cancel_btn.ForeColor = Color.WhiteSmoke;
            Cancel_btn.Location = new Point(144, 147);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(87, 31);
            Cancel_btn.TabIndex = 2;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = false;
            // 
            // Exit_btn
            // 
            Exit_btn.BackColor = Color.IndianRed;
            Exit_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Exit_btn.ForeColor = Color.WhiteSmoke;
            Exit_btn.Location = new Point(263, 147);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(87, 31);
            Exit_btn.TabIndex = 2;
            Exit_btn.Text = "Exit";
            Exit_btn.UseVisualStyleBackColor = false;
            // 
            // MainLoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Exit_btn);
            Controls.Add(Cancel_btn);
            Controls.Add(Login_btn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainLoginScreen";
            Size = new Size(385, 210);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Login_btn;
        private Button Cancel_btn;
        private Button Exit_btn;
    }
}
