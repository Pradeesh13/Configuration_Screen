namespace ConfigurationScreen.UserControls.IOChannelMapping
{
    partial class IOChannelMappingScreen
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
            ChannelMapping_btn = new Button();
            IOMapping_btn = new Button();
            IOChannel_panel = new Panel();
            SuspendLayout();
            // 
            // ChannelMapping_btn
            // 
            ChannelMapping_btn.BackColor = Color.Gainsboro;
            ChannelMapping_btn.Cursor = Cursors.Hand;
            ChannelMapping_btn.FlatAppearance.BorderColor = Color.Black;
            ChannelMapping_btn.FlatAppearance.BorderSize = 2;
            ChannelMapping_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ChannelMapping_btn.Location = new Point(0, 1);
            ChannelMapping_btn.Name = "ChannelMapping_btn";
            ChannelMapping_btn.Size = new Size(820, 32);
            ChannelMapping_btn.TabIndex = 0;
            ChannelMapping_btn.Text = "Channel Mapping";
            ChannelMapping_btn.UseVisualStyleBackColor = false;
            ChannelMapping_btn.Click += ChannelMapping_btn_Click;
            // 
            // IOMapping_btn
            // 
            IOMapping_btn.BackColor = Color.Gainsboro;
            IOMapping_btn.FlatAppearance.BorderColor = Color.Black;
            IOMapping_btn.FlatAppearance.BorderSize = 2;
            IOMapping_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            IOMapping_btn.Location = new Point(819, 1);
            IOMapping_btn.Name = "IOMapping_btn";
            IOMapping_btn.Size = new Size(804, 32);
            IOMapping_btn.TabIndex = 0;
            IOMapping_btn.Text = "IO Mapping";
            IOMapping_btn.UseVisualStyleBackColor = false;
            IOMapping_btn.Click += IOMapping_btn_Click;
            // 
            // IOChannel_panel
            // 
            IOChannel_panel.Location = new Point(2, 33);
            IOChannel_panel.Name = "IOChannel_panel";
            IOChannel_panel.Size = new Size(1621, 835);
            IOChannel_panel.TabIndex = 1;
            // 
            // IOChannelMappingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(IOChannel_panel);
            Controls.Add(IOMapping_btn);
            Controls.Add(ChannelMapping_btn);
            Name = "IOChannelMappingScreen";
            Size = new Size(1623, 880);
            ResumeLayout(false);
        }

        #endregion

        private Button ChannelMapping_btn;
        private Button IOMapping_btn;
        private Panel IOChannel_panel;
    }
}
