namespace ConfigurationScreen.UserControls.IOChannelMapping
{
    partial class ChannelMappingScreen
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
            ChannelMapping_panel = new Panel();
            PLC_btn = new Button();
            Daq_btn = new Button();
            SuspendLayout();
            // 
            // ChannelMapping_panel
            // 
            ChannelMapping_panel.Location = new Point(87, 3);
            ChannelMapping_panel.Name = "ChannelMapping_panel";
            ChannelMapping_panel.Size = new Size(1536, 874);
            ChannelMapping_panel.TabIndex = 0;
            // 
            // PLC_btn
            // 
            PLC_btn.BackColor = Color.LightGray;
            PLC_btn.Location = new Point(1, 64);
            PLC_btn.Name = "PLC_btn";
            PLC_btn.Size = new Size(86, 63);
            PLC_btn.TabIndex = 1;
            PLC_btn.Text = "PLC";
            PLC_btn.UseVisualStyleBackColor = false;
            PLC_btn.Click += PLC_btn_Click;
            // 
            // Daq_btn
            // 
            Daq_btn.BackColor = Color.Gainsboro;
            Daq_btn.Location = new Point(0, 1);
            Daq_btn.Name = "Daq_btn";
            Daq_btn.Size = new Size(87, 63);
            Daq_btn.TabIndex = 1;
            Daq_btn.Text = "DAQ";
            Daq_btn.UseVisualStyleBackColor = false;
            Daq_btn.Click += DAQ_btn_Click;
            // 
            // ChannelMappingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Daq_btn);
            Controls.Add(PLC_btn);
            Controls.Add(ChannelMapping_panel);
            Name = "ChannelMappingScreen";
            Size = new Size(1623, 880);
            ResumeLayout(false);
        }

        #endregion

        private Panel ChannelMapping_panel;
        private Button PLC_btn;
        private Button Daq_btn;
    }
}
