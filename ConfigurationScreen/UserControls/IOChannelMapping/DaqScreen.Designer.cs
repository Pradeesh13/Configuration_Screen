namespace ConfigurationScreen.UserControls.IOChannelMapping
{
    partial class DaqScreen
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
            Daq_tabcontrol = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            DaqAISamplePerChannel_numbox = new NumericUpDown();
            DaqAOSamplePerChannel_numbox = new NumericUpDown();
            DaqAISamplingRate_numbox = new NumericUpDown();
            DaqAOSamplingRate_numbox = new NumericUpDown();
            DaqAO_grid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            DaqAI_grid = new DataGridView();
            TagName = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Min = new DataGridViewTextBoxColumn();
            Max = new DataGridViewTextBoxColumn();
            Port = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            label8 = new Label();
            label7 = new Label();
            DaqDI_grid = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            DaqDO_grid = new DataGridView();
            DO_TagName = new DataGridViewTextBoxColumn();
            DO_PortNumber = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            label10 = new Label();
            label9 = new Label();
            DaqCO_grid = new DataGridView();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            DaqCI_grid = new DataGridView();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            Daq_tabcontrol.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DaqAISamplePerChannel_numbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DaqAOSamplePerChannel_numbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DaqAISamplingRate_numbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DaqAOSamplingRate_numbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DaqAO_grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DaqAI_grid).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DaqDI_grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DaqDO_grid).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DaqCO_grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DaqCI_grid).BeginInit();
            SuspendLayout();
            // 
            // Daq_tabcontrol
            // 
            Daq_tabcontrol.Appearance = TabAppearance.FlatButtons;
            Daq_tabcontrol.Controls.Add(tabPage1);
            Daq_tabcontrol.Controls.Add(tabPage2);
            Daq_tabcontrol.Controls.Add(tabPage3);
            Daq_tabcontrol.Cursor = Cursors.Hand;
            Daq_tabcontrol.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Daq_tabcontrol.Location = new Point(3, 3);
            Daq_tabcontrol.Name = "Daq_tabcontrol";
            Daq_tabcontrol.SelectedIndex = 0;
            Daq_tabcontrol.Size = new Size(1530, 868);
            Daq_tabcontrol.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(DaqAISamplePerChannel_numbox);
            tabPage1.Controls.Add(DaqAOSamplePerChannel_numbox);
            tabPage1.Controls.Add(DaqAISamplingRate_numbox);
            tabPage1.Controls.Add(DaqAOSamplingRate_numbox);
            tabPage1.Controls.Add(DaqAO_grid);
            tabPage1.Controls.Add(DaqAI_grid);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1522, 832);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Analog output/ Analog Input";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1156, 71);
            label4.Name = "label4";
            label4.Size = new Size(171, 21);
            label4.TabIndex = 3;
            label4.Text = "Sample Per Channel :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 72);
            label2.Name = "label2";
            label2.Size = new Size(171, 21);
            label2.TabIndex = 3;
            label2.Text = "Sample Per Channel :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(823, 70);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 3;
            label3.Text = "Sampling Rate :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1058, 119);
            label6.Name = "label6";
            label6.Size = new Size(168, 21);
            label6.TabIndex = 3;
            label6.Text = "DAQ ANALOG INPUT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 119);
            label5.Name = "label5";
            label5.Size = new Size(183, 21);
            label5.TabIndex = 3;
            label5.Text = "DAQ ANALOG OUTPUT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 68);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 3;
            label1.Text = "Sampling Rate :";
            // 
            // DaqAISamplePerChannel_numbox
            // 
            DaqAISamplePerChannel_numbox.Location = new Point(1330, 67);
            DaqAISamplePerChannel_numbox.Name = "DaqAISamplePerChannel_numbox";
            DaqAISamplePerChannel_numbox.Size = new Size(120, 29);
            DaqAISamplePerChannel_numbox.TabIndex = 2;
            // 
            // DaqAOSamplePerChannel_numbox
            // 
            DaqAOSamplePerChannel_numbox.Location = new Point(575, 68);
            DaqAOSamplePerChannel_numbox.Name = "DaqAOSamplePerChannel_numbox";
            DaqAOSamplePerChannel_numbox.Size = new Size(120, 29);
            DaqAOSamplePerChannel_numbox.TabIndex = 2;
            // 
            // DaqAISamplingRate_numbox
            // 
            DaqAISamplingRate_numbox.Location = new Point(954, 64);
            DaqAISamplingRate_numbox.Name = "DaqAISamplingRate_numbox";
            DaqAISamplingRate_numbox.Size = new Size(121, 29);
            DaqAISamplingRate_numbox.TabIndex = 2;
            // 
            // DaqAOSamplingRate_numbox
            // 
            DaqAOSamplingRate_numbox.Location = new Point(185, 65);
            DaqAOSamplingRate_numbox.Name = "DaqAOSamplingRate_numbox";
            DaqAOSamplingRate_numbox.Size = new Size(120, 29);
            DaqAOSamplingRate_numbox.TabIndex = 2;
            // 
            // DaqAO_grid
            // 
            DaqAO_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DaqAO_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DaqAO_grid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            DaqAO_grid.Location = new Point(54, 148);
            DaqAO_grid.Name = "DaqAO_grid";
            DaqAO_grid.RowHeadersVisible = false;
            DaqAO_grid.Size = new Size(641, 586);
            DaqAO_grid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Tag Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Type";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Min";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Max";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Port";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // DaqAI_grid
            // 
            DaqAI_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DaqAI_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DaqAI_grid.Columns.AddRange(new DataGridViewColumn[] { TagName, Type, Min, Max, Port });
            DaqAI_grid.Location = new Point(823, 148);
            DaqAI_grid.Name = "DaqAI_grid";
            DaqAI_grid.RowHeadersVisible = false;
            DaqAI_grid.Size = new Size(632, 586);
            DaqAI_grid.TabIndex = 0;
            // 
            // TagName
            // 
            TagName.HeaderText = "Tag Name";
            TagName.Name = "TagName";
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            // 
            // Min
            // 
            Min.HeaderText = "Min";
            Min.Name = "Min";
            // 
            // Max
            // 
            Max.HeaderText = "Max";
            Max.Name = "Max";
            // 
            // Port
            // 
            Port.HeaderText = "Port";
            Port.Name = "Port";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(DaqDI_grid);
            tabPage2.Controls.Add(DaqDO_grid);
            tabPage2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1522, 793);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Digital Output / Digital Input";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1009, 54);
            label8.Name = "label8";
            label8.Size = new Size(162, 21);
            label8.TabIndex = 2;
            label8.Text = "DAQ DIGITAL INPUT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(334, 54);
            label7.Name = "label7";
            label7.Size = new Size(177, 21);
            label7.TabIndex = 2;
            label7.Text = "DAQ DIGITAL OUTPUT";
            // 
            // DaqDI_grid
            // 
            DaqDI_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DaqDI_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DaqDI_grid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            DaqDI_grid.Location = new Point(841, 86);
            DaqDI_grid.Name = "DaqDI_grid";
            DaqDI_grid.RowHeadersVisible = false;
            DaqDI_grid.Size = new Size(498, 632);
            DaqDI_grid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Tag Name";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Port Number";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // DaqDO_grid
            // 
            DaqDO_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DaqDO_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DaqDO_grid.Columns.AddRange(new DataGridViewColumn[] { DO_TagName, DO_PortNumber });
            DaqDO_grid.Location = new Point(182, 86);
            DaqDO_grid.Name = "DaqDO_grid";
            DaqDO_grid.RowHeadersVisible = false;
            DaqDO_grid.Size = new Size(491, 632);
            DaqDO_grid.TabIndex = 0;
            // 
            // DO_TagName
            // 
            DO_TagName.HeaderText = "Tag Name";
            DO_TagName.Name = "DO_TagName";
            // 
            // DO_PortNumber
            // 
            DO_PortNumber.HeaderText = "Port Number";
            DO_PortNumber.Name = "DO_PortNumber";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(DaqCO_grid);
            tabPage3.Controls.Add(DaqCI_grid);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1522, 793);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Counter Output /  Digital Input";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(976, 47);
            label10.Name = "label10";
            label10.Size = new Size(166, 20);
            label10.TabIndex = 4;
            label10.Text = "DAQ COUNTER INPUT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(334, 47);
            label9.Name = "label9";
            label9.Size = new Size(180, 20);
            label9.TabIndex = 4;
            label9.Text = "DAQ COUNTER OUTPUT";
            // 
            // DaqCO_grid
            // 
            DaqCO_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DaqCO_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DaqCO_grid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13 });
            DaqCO_grid.Location = new Point(180, 76);
            DaqCO_grid.Name = "DaqCO_grid";
            DaqCO_grid.RowHeadersVisible = false;
            DaqCO_grid.Size = new Size(501, 643);
            DaqCO_grid.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Tag Name";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Port Number";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // DaqCI_grid
            // 
            DaqCI_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DaqCI_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DaqCI_grid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            DaqCI_grid.Location = new Point(819, 76);
            DaqCI_grid.Name = "DaqCI_grid";
            DaqCI_grid.RowHeadersVisible = false;
            DaqCI_grid.Size = new Size(504, 643);
            DaqCI_grid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Tag Name";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Port Number";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // DaqScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Daq_tabcontrol);
            Name = "DaqScreen";
            Size = new Size(1536, 874);
            Daq_tabcontrol.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DaqAISamplePerChannel_numbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DaqAOSamplePerChannel_numbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DaqAISamplingRate_numbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DaqAOSamplingRate_numbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DaqAO_grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)DaqAI_grid).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DaqDI_grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)DaqDO_grid).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DaqCO_grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)DaqCI_grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Daq_tabcontrol;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView DaqAI_grid;
        private DataGridViewTextBoxColumn TagName;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Min;
        private DataGridViewTextBoxColumn Max;
        private DataGridViewTextBoxColumn Port;
        private DataGridView DaqAO_grid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridView DaqDO_grid;
        private DataGridViewTextBoxColumn DO_TagName;
        private DataGridViewTextBoxColumn DO_PortNumber;
        private DataGridView DaqDI_grid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridView DaqCO_grid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridView DaqCI_grid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private NumericUpDown DaqAOSamplingRate_numbox;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label1;
        private NumericUpDown DaqAISamplePerChannel_numbox;
        private NumericUpDown DaqAOSamplePerChannel_numbox;
        private NumericUpDown DaqAISamplingRate_numbox;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label9;
    }
}
