namespace ConfigurationScreen
{
    partial class Configuration_Screen
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
            InstrumentConfig_btn = new Button();
            Config_panel = new Panel();
            SuspendLayout();
            // 
            // InstrumentConfig_btn
            // 
            InstrumentConfig_btn.AutoSize = true;
            InstrumentConfig_btn.BackColor = SystemColors.ControlLight;
            InstrumentConfig_btn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            InstrumentConfig_btn.Location = new Point(35, 76);
            InstrumentConfig_btn.Name = "InstrumentConfig_btn";
            InstrumentConfig_btn.Size = new Size(156, 66);
            InstrumentConfig_btn.TabIndex = 1;
            InstrumentConfig_btn.Text = "Instrument\r\nConfiguration\r\n";
            InstrumentConfig_btn.UseVisualStyleBackColor = false;
            InstrumentConfig_btn.Click += InstrumentConfig_btn_Click;
            // 
            // Config_panel
            // 
            Config_panel.BorderStyle = BorderStyle.FixedSingle;
            Config_panel.Location = new Point(341, 76);
            Config_panel.Name = "Config_panel";
            Config_panel.Size = new Size(1467, 780);
            Config_panel.TabIndex = 0;
            // 
            // Configuration_Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1836, 892);
            Controls.Add(InstrumentConfig_btn);
            Controls.Add(Config_panel);
            Font = new Font("Segoe UI", 9F);
            Name = "Configuration_Screen";
            Text = "Configuration Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button InstrumentConfig_btn;
        private Panel Config_panel;
    }
}
