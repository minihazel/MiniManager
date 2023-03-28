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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clientModsCounter = new System.Windows.Forms.Label();
            this.serverModsCounter = new System.Windows.Forms.Label();
            this.serverModsDrop = new System.Windows.Forms.GroupBox();
            this.serverModsList = new System.Windows.Forms.GroupBox();
            this.clientModsPanel.SuspendLayout();
            this.serverModsPanel.SuspendLayout();
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
            this.clientModsPanel.Controls.Add(this.clientModsCounter);
            this.clientModsPanel.Controls.Add(this.groupBox2);
            this.clientModsPanel.Controls.Add(this.groupBox1);
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
            this.serverModsPanel.Controls.Add(this.serverModsCounter);
            this.serverModsPanel.Controls.Add(this.serverModsDrop);
            this.serverModsPanel.Controls.Add(this.serverModsList);
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
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 531);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client mods";
            // 
            // groupBox2
            // 
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(308, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drag and drop mods here";
            // 
            // clientModsCounter
            // 
            this.clientModsCounter.Font = new System.Drawing.Font("Bahnschrift Light", 7F);
            this.clientModsCounter.ForeColor = System.Drawing.Color.DimGray;
            this.clientModsCounter.Location = new System.Drawing.Point(10, 545);
            this.clientModsCounter.Name = "clientModsCounter";
            this.clientModsCounter.Size = new System.Drawing.Size(282, 15);
            this.clientModsCounter.TabIndex = 2;
            this.clientModsCounter.Text = "xx mods";
            this.clientModsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serverModsCounter
            // 
            this.serverModsCounter.Font = new System.Drawing.Font("Bahnschrift Light", 7F);
            this.serverModsCounter.ForeColor = System.Drawing.Color.DimGray;
            this.serverModsCounter.Location = new System.Drawing.Point(10, 545);
            this.serverModsCounter.Name = "serverModsCounter";
            this.serverModsCounter.Size = new System.Drawing.Size(282, 15);
            this.serverModsCounter.TabIndex = 5;
            this.serverModsCounter.Text = "xx mods";
            this.serverModsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serverModsDrop
            // 
            this.serverModsDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverModsDrop.ForeColor = System.Drawing.Color.LightGray;
            this.serverModsDrop.Location = new System.Drawing.Point(308, 11);
            this.serverModsDrop.Name = "serverModsDrop";
            this.serverModsDrop.Size = new System.Drawing.Size(321, 160);
            this.serverModsDrop.TabIndex = 4;
            this.serverModsDrop.TabStop = false;
            this.serverModsDrop.Text = "Drag and drop mods here";
            // 
            // serverModsList
            // 
            this.serverModsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverModsList.ForeColor = System.Drawing.Color.LightGray;
            this.serverModsList.Location = new System.Drawing.Point(12, 11);
            this.serverModsList.Name = "serverModsList";
            this.serverModsList.Size = new System.Drawing.Size(280, 531);
            this.serverModsList.TabIndex = 3;
            this.serverModsList.TabStop = false;
            this.serverModsList.Text = "Server mods";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(902, 585);
            this.Controls.Add(this.verticalSeparator1);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.serverModsPanel);
            this.Controls.Add(this.clientModsPanel);
            this.Controls.Add(this.appSettingsPanel);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Manager";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.clientModsPanel.ResumeLayout(false);
            this.serverModsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tabPanel;
        private System.Windows.Forms.Panel verticalSeparator1;
        private System.Windows.Forms.Panel clientModsPanel;
        private System.Windows.Forms.Panel serverModsPanel;
        private System.Windows.Forms.Panel appSettingsPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label clientModsCounter;
        private System.Windows.Forms.Label serverModsCounter;
        private System.Windows.Forms.GroupBox serverModsDrop;
        private System.Windows.Forms.GroupBox serverModsList;
    }
}

