namespace ConfigurationScreen.UserControls.IOChannelMapping
{
    partial class ChannelMappinScreen
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
            button1 = new Button();
            DAQ = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(87, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1377, 774);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1, 64);
            button1.Name = "button1";
            button1.Size = new Size(86, 63);
            button1.TabIndex = 1;
            button1.Text = "PLC";
            button1.UseVisualStyleBackColor = true;
            // 
            // DAQ
            // 
            DAQ.Location = new Point(0, 1);
            DAQ.Name = "DAQ";
            DAQ.Size = new Size(87, 63);
            DAQ.TabIndex = 1;
            DAQ.Text = "DAQ";
            DAQ.UseVisualStyleBackColor = true;
            // 
            // ChannelMappinScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DAQ);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "ChannelMappinScreen";
            Size = new Size(1467, 780);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button DAQ;
    }
}
