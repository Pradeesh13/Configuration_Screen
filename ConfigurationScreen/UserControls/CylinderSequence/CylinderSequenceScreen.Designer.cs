namespace ConfigurationScreen.UserControls.FunctionalSequence
{
    partial class CylinderSequenceScreen
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Cycle_Work_On = new DataGridViewComboBoxColumn();
            Cycle_Work_FB = new DataGridViewComboBoxColumn();
            Cycle_Home_On = new DataGridViewComboBoxColumn();
            Cycle_Home_FB = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Cycle_Work_On, Cycle_Work_FB, Cycle_Home_On, Cycle_Home_FB });
            dataGridView1.Location = new Point(157, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1287, 646);
            dataGridView1.TabIndex = 0;
            // 
            // Cycle_Work_On
            // 
            Cycle_Work_On.HeaderText = "Cycle Work ON";
            Cycle_Work_On.Name = "Cycle_Work_On";
            // 
            // Cycle_Work_FB
            // 
            Cycle_Work_FB.HeaderText = "Cycle Work FB";
            Cycle_Work_FB.Name = "Cycle_Work_FB";
            // 
            // Cycle_Home_On
            // 
            Cycle_Home_On.HeaderText = "Cycl Home On";
            Cycle_Home_On.Name = "Cycle_Home_On";
            // 
            // Cycle_Home_FB
            // 
            Cycle_Home_FB.HeaderText = "Cycle_Home_FB";
            Cycle_Home_FB.Name = "Cycle_Home_FB";
            // 
            // CylinderSequenceScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Name = "CylinderSequenceScreen";
            Size = new Size(1623, 880);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewComboBoxColumn Cycle_Work_On;
        private DataGridViewComboBoxColumn Cycle_Work_FB;
        private DataGridViewComboBoxColumn Cycle_Home_On;
        private DataGridViewComboBoxColumn Cycle_Home_FB;
    }
}
