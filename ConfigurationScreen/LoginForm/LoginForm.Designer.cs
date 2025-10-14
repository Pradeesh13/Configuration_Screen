namespace ConfigurationScreen.LoginForm
{
    partial class LoginForm
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
            Exit_btn = new Button();
            Cancel_btn = new Button();
            Login_btn = new Button();
            Password_txtbox = new TextBox();
            UserName_txtbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(140, 5);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 1;
            label1.Text = "Login Screen";
            // 
            // Exit_btn
            // 
            Exit_btn.BackColor = Color.OrangeRed;
            Exit_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Exit_btn.ForeColor = Color.WhiteSmoke;
            Exit_btn.Location = new Point(271, 157);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(87, 31);
            Exit_btn.TabIndex = 7;
            Exit_btn.Text = "Exit";
            Exit_btn.UseVisualStyleBackColor = false;
            Exit_btn.Click += Exit_btn_Click;
            // 
            // Cancel_btn
            // 
            Cancel_btn.BackColor = Color.OrangeRed;
            Cancel_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Cancel_btn.ForeColor = Color.WhiteSmoke;
            Cancel_btn.Location = new Point(152, 157);
            Cancel_btn.Name = "Cancel_btn";
            Cancel_btn.Size = new Size(87, 31);
            Cancel_btn.TabIndex = 8;
            Cancel_btn.Text = "Cancel";
            Cancel_btn.UseVisualStyleBackColor = false;
            Cancel_btn.Click += Cancel_btn_Click;
            // 
            // Login_btn
            // 
            Login_btn.BackColor = Color.OrangeRed;
            Login_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Login_btn.ForeColor = Color.WhiteSmoke;
            Login_btn.Location = new Point(32, 157);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(87, 31);
            Login_btn.TabIndex = 9;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = false;
            Login_btn.Click += Login_btn_Click;
            // 
            // Password_txtbox
            // 
            Password_txtbox.BackColor = Color.White;
            Password_txtbox.BorderStyle = BorderStyle.FixedSingle;
            Password_txtbox.Font = new Font("Segoe UI", 14F);
            Password_txtbox.ForeColor = Color.Firebrick;
            Password_txtbox.Location = new Point(142, 100);
            Password_txtbox.Name = "Password_txtbox";
            Password_txtbox.Size = new Size(217, 32);
            Password_txtbox.TabIndex = 5;
            // 
            // UserName_txtbox
            // 
            UserName_txtbox.BorderStyle = BorderStyle.FixedSingle;
            UserName_txtbox.Font = new Font("Segoe UI", 14F);
            UserName_txtbox.ForeColor = Color.Firebrick;
            UserName_txtbox.Location = new Point(142, 48);
            UserName_txtbox.Name = "UserName_txtbox";
            UserName_txtbox.Size = new Size(217, 32);
            UserName_txtbox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(74, 49);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 3;
            label2.Text = "User :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(28, 101);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 4;
            label3.Text = "Password :";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(396, 203);
            Controls.Add(Exit_btn);
            Controls.Add(Cancel_btn);
            Controls.Add(Login_btn);
            Controls.Add(Password_txtbox);
            Controls.Add(UserName_txtbox);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button Exit_btn;
        private Button Cancel_btn;
        private Button Login_btn;
        private TextBox Password_txtbox;
        private TextBox UserName_txtbox;
        private Label label2;
        private Label label3;
    }
}