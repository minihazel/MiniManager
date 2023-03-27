namespace MiniManager
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tabPanel = new System.Windows.Forms.Panel();
            this.verticalSeparator1 = new System.Windows.Forms.Panel();
            this.clientModsPanel = new System.Windows.Forms.Panel();
            this.serverModsPanel = new System.Windows.Forms.Panel();
            this.appSettingsPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabPanel.Location = new System.Drawing.Point(0, 12);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(257, 561);
            this.tabPanel.TabIndex = 0;
            // 
            // verticalSeparator1
            // 
            this.verticalSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.verticalSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.verticalSeparator1.Location = new System.Drawing.Point(257, 0);
            this.verticalSeparator1.Name = "verticalSeparator1";
            this.verticalSeparator1.Size = new System.Drawing.Size(1, 586);
            this.verticalSeparator1.TabIndex = 1;
            // 
            // clientModsPanel
            // 
            this.clientModsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientModsPanel.Location = new System.Drawing.Point(261, 1);
            this.clientModsPanel.Name = "clientModsPanel";
            this.clientModsPanel.Size = new System.Drawing.Size(640, 584);
            this.clientModsPanel.TabIndex = 2;
            // 
            // serverModsPanel
            // 
            this.serverModsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverModsPanel.Location = new System.Drawing.Point(261, 1);
            this.serverModsPanel.Name = "serverModsPanel";
            this.serverModsPanel.Size = new System.Drawing.Size(640, 584);
            this.serverModsPanel.TabIndex = 3;
            // 
            // appSettingsPanel
            // 
            this.appSettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appSettingsPanel.Location = new System.Drawing.Point(261, 1);
            this.appSettingsPanel.Name = "appSettingsPanel";
            this.appSettingsPanel.Size = new System.Drawing.Size(640, 584);
            this.appSettingsPanel.TabIndex = 4;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(902, 585);
            this.Controls.Add(this.verticalSeparator1);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.clientModsPanel);
            this.Controls.Add(this.appSettingsPanel);
            this.Controls.Add(this.serverModsPanel);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Manager";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tabPanel;
        private System.Windows.Forms.Panel verticalSeparator1;
        private System.Windows.Forms.Panel clientModsPanel;
        private System.Windows.Forms.Panel serverModsPanel;
        private System.Windows.Forms.Panel appSettingsPanel;
    }
}

