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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(1, 1);
            button1.Name = "button1";
            button1.Size = new Size(729, 32);
            button1.TabIndex = 0;
            button1.Text = "Channel Mapping";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(728, 1);
            button2.Name = "button2";
            button2.Size = new Size(706, 32);
            button2.TabIndex = 0;
            button2.Text = "IO Mapping";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(2, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(1430, 790);
            panel1.TabIndex = 1;
            // 
            // IOChannelMappingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "IOChannelMappingScreen";
            Size = new Size(1436, 827);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panel1;
    }
}
