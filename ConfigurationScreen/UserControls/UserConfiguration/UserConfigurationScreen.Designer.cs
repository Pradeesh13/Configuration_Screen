namespace ConfigurationScreen.UserControls.UserConfiguration
{
    partial class UserConfigurationScreen
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserConfigurationScreen));
            UserLevel_cmbbox = new ComboBox();
            UserName_txtbox = new TextBox();
            Password_txtbox = new TextBox();
            ConfirmPassword_txtbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            UserList_grid = new DataGridView();
            Username_List = new DataGridViewTextBoxColumn();
            AddUser_picbox = new PictureBox();
            RemoveUser_picbox = new PictureBox();
            UpdateUser_picbox = new PictureBox();
            NewFile_picbox = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)UserList_grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddUser_picbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RemoveUser_picbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateUser_picbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NewFile_picbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // UserLevel_cmbbox
            // 
            UserLevel_cmbbox.DropDownStyle = ComboBoxStyle.DropDownList;
            UserLevel_cmbbox.Font = new Font("Microsoft Sans Serif", 12F);
            UserLevel_cmbbox.FormattingEnabled = true;
            UserLevel_cmbbox.Items.AddRange(new object[] { "Administator", "Operator" });
            UserLevel_cmbbox.Location = new Point(341, 303);
            UserLevel_cmbbox.Name = "UserLevel_cmbbox";
            UserLevel_cmbbox.Size = new Size(200, 28);
            UserLevel_cmbbox.TabIndex = 0;
            // 
            // UserName_txtbox
            // 
            UserName_txtbox.Font = new Font("Microsoft Sans Serif", 12F);
            UserName_txtbox.Location = new Point(341, 370);
            UserName_txtbox.Name = "UserName_txtbox";
            UserName_txtbox.Size = new Size(200, 26);
            UserName_txtbox.TabIndex = 1;
            // 
            // Password_txtbox
            // 
            Password_txtbox.Font = new Font("Microsoft Sans Serif", 12F);
            Password_txtbox.Location = new Point(341, 435);
            Password_txtbox.Name = "Password_txtbox";
            Password_txtbox.Size = new Size(200, 26);
            Password_txtbox.TabIndex = 1;
            // 
            // ConfirmPassword_txtbox
            // 
            ConfirmPassword_txtbox.Font = new Font("Microsoft Sans Serif", 12F);
            ConfirmPassword_txtbox.Location = new Point(341, 499);
            ConfirmPassword_txtbox.Name = "ConfirmPassword_txtbox";
            ConfirmPassword_txtbox.Size = new Size(200, 26);
            ConfirmPassword_txtbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(341, 275);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 2;
            label1.Text = "User Level";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(341, 341);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.Location = new Point(341, 405);
            label3.Name = "label3";
            label3.Size = new Size(81, 24);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(341, 475);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 2;
            label4.Text = "Confirm Password";
            // 
            // UserList_grid
            // 
            UserList_grid.AllowUserToAddRows = false;
            UserList_grid.AllowUserToDeleteRows = false;
            UserList_grid.BackgroundColor = SystemColors.ControlLight;
            UserList_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserList_grid.Columns.AddRange(new DataGridViewColumn[] { Username_List });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            UserList_grid.DefaultCellStyle = dataGridViewCellStyle2;
            UserList_grid.Location = new Point(801, 227);
            UserList_grid.Name = "UserList_grid";
            UserList_grid.Size = new Size(307, 357);
            UserList_grid.TabIndex = 3;
            UserList_grid.CellClick += UserList_grid_CellClick;
            // 
            // Username_List
            // 
            Username_List.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username_List.DefaultCellStyle = dataGridViewCellStyle1;
            Username_List.HeaderText = "Username_List";
            Username_List.Name = "Username_List";
            // 
            // AddUser_picbox
            // 
            AddUser_picbox.Image = (Image)resources.GetObject("AddUser_picbox.Image");
            AddUser_picbox.Location = new Point(642, 320);
            AddUser_picbox.Name = "AddUser_picbox";
            AddUser_picbox.Size = new Size(50, 40);
            AddUser_picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            AddUser_picbox.TabIndex = 4;
            AddUser_picbox.TabStop = false;
            AddUser_picbox.Click += AddUser_picbox_Click;
            // 
            // RemoveUser_picbox
            // 
            RemoveUser_picbox.Image = (Image)resources.GetObject("RemoveUser_picbox.Image");
            RemoveUser_picbox.Location = new Point(646, 457);
            RemoveUser_picbox.Name = "RemoveUser_picbox";
            RemoveUser_picbox.Size = new Size(42, 41);
            RemoveUser_picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            RemoveUser_picbox.TabIndex = 4;
            RemoveUser_picbox.TabStop = false;
            RemoveUser_picbox.Click += RemoveUser_picbox_Click;
            // 
            // UpdateUser_picbox
            // 
            UpdateUser_picbox.Image = (Image)resources.GetObject("UpdateUser_picbox.Image");
            UpdateUser_picbox.Location = new Point(641, 382);
            UpdateUser_picbox.Name = "UpdateUser_picbox";
            UpdateUser_picbox.Size = new Size(51, 48);
            UpdateUser_picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            UpdateUser_picbox.TabIndex = 4;
            UpdateUser_picbox.TabStop = false;
            UpdateUser_picbox.Click += UpdateUser_picbox_Click;
            // 
            // NewFile_picbox
            // 
            NewFile_picbox.Image = (Image)resources.GetObject("NewFile_picbox.Image");
            NewFile_picbox.Location = new Point(641, 249);
            NewFile_picbox.Name = "NewFile_picbox";
            NewFile_picbox.Size = new Size(51, 44);
            NewFile_picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            NewFile_picbox.TabIndex = 4;
            NewFile_picbox.TabStop = false;
            NewFile_picbox.Click += NewFile_picbox_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(646, 520);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 43);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // UserConfigurationScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(NewFile_picbox);
            Controls.Add(pictureBox5);
            Controls.Add(RemoveUser_picbox);
            Controls.Add(UpdateUser_picbox);
            Controls.Add(AddUser_picbox);
            Controls.Add(UserList_grid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ConfirmPassword_txtbox);
            Controls.Add(Password_txtbox);
            Controls.Add(UserName_txtbox);
            Controls.Add(UserLevel_cmbbox);
            Name = "UserConfigurationScreen";
            Size = new Size(1467, 780);
            ((System.ComponentModel.ISupportInitialize)UserList_grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddUser_picbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)RemoveUser_picbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateUser_picbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)NewFile_picbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox UserLevel_cmbbox;
        private TextBox UserName_txtbox;
        private TextBox Password_txtbox;
        private TextBox ConfirmPassword_txtbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView UserList_grid;
        private DataGridViewTextBoxColumn Username_List;
        private PictureBox AddUser_picbox;
        private PictureBox RemoveUser_picbox;
        private PictureBox UpdateUser_picbox;
        private PictureBox NewFile_picbox;
        private PictureBox pictureBox5;
    }
}
