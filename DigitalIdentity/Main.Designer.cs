namespace DevFINITY.DigitalIdentity
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.mainPanel = new DevComponents.DotNetBar.PanelEx();
            this.panelManager = new SwingWERX.Controls.PanelManager();
            this.loginPanel = new SwingWERX.Controls.ManagedPanel();
            this.tileButton1 = new DevFINITY.DigitalIdentity.Controls.TileButton();
            this.managedPanel2 = new SwingWERX.Controls.ManagedPanel();
            this.headerPanel = new DevComponents.DotNetBar.PanelEx();
            this.label1 = new System.Windows.Forms.Label();
            this.picDevFINITY = new System.Windows.Forms.PictureBox();
            this.lblDigitalIdentity = new System.Windows.Forms.Label();
            this.picFingerprint = new System.Windows.Forms.PictureBox();
            this.lblDevFINITY = new System.Windows.Forms.Label();
            this.minimizeButton = new SwingWERX.Controls.FormButton(this.components);
            this.maximizeButton = new SwingWERX.Controls.FormButton(this.components);
            this.closeButton = new SwingWERX.Controls.FormButton(this.components);
            this.mainPanel.SuspendLayout();
            this.panelManager.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDevFINITY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerprint)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // mainPanel
            // 
            this.mainPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.mainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mainPanel.Controls.Add(this.panelManager);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Controls.Add(this.minimizeButton);
            this.mainPanel.Controls.Add(this.maximizeButton);
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1024, 768);
            this.mainPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mainPanel.Style.BackColor1.Color = System.Drawing.Color.White;
            this.mainPanel.Style.BackColor2.Color = System.Drawing.Color.White;
            this.mainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mainPanel.Style.BorderWidth = 0;
            this.mainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mainPanel.Style.GradientAngle = 90;
            this.mainPanel.TabIndex = 2;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // panelManager
            // 
            this.panelManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManager.BackColor = System.Drawing.Color.White;
            this.panelManager.Controls.Add(this.loginPanel);
            this.panelManager.Controls.Add(this.managedPanel2);
            this.panelManager.ForeColor = System.Drawing.Color.Black;
            this.panelManager.Location = new System.Drawing.Point(0, 108);
            this.panelManager.Name = "panelManager";
            this.panelManager.SelectedIndex = 0;
            this.panelManager.SelectedPanel = this.loginPanel;
            this.panelManager.Size = new System.Drawing.Size(1024, 660);
            this.panelManager.TabIndex = 7;
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.tileButton1);
            this.loginPanel.ForeColor = System.Drawing.Color.Black;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1024, 660);
            // 
            // tileButton1
            // 
            this.tileButton1.BackColor = System.Drawing.Color.White;
            this.tileButton1.FlatAppearance.BorderSize = 0;
            this.tileButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton1.ForeColor = System.Drawing.Color.Black;
            this.tileButton1.Image = global::DevFINITY.DigitalIdentity.Properties.Resources.add_fingerprint;
            this.tileButton1.Location = new System.Drawing.Point(470, 480);
            this.tileButton1.Name = "tileButton1";
            this.tileButton1.Size = new System.Drawing.Size(85, 130);
            this.tileButton1.TabIndex = 0;
            this.tileButton1.Text = "Login";
            this.tileButton1.UseVisualStyleBackColor = false;
            // 
            // managedPanel2
            // 
            this.managedPanel2.BackColor = System.Drawing.Color.White;
            this.managedPanel2.ForeColor = System.Drawing.Color.Black;
            this.managedPanel2.Location = new System.Drawing.Point(0, 0);
            this.managedPanel2.Name = "managedPanel2";
            this.managedPanel2.Size = new System.Drawing.Size(0, 0);
            this.managedPanel2.Text = "managedPanel2";
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.headerPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.picDevFINITY);
            this.headerPanel.Controls.Add(this.lblDigitalIdentity);
            this.headerPanel.Controls.Add(this.picFingerprint);
            this.headerPanel.Controls.Add(this.lblDevFINITY);
            this.headerPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.headerPanel.Location = new System.Drawing.Point(0, 30);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1024, 75);
            this.headerPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.headerPanel.Style.BackColor1.Color = System.Drawing.Color.White;
            this.headerPanel.Style.BackColor2.Color = System.Drawing.Color.White;
            this.headerPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.headerPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.headerPanel.Style.BorderWidth = 0;
            this.headerPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.headerPanel.Style.GradientAngle = 90;
            this.headerPanel.TabIndex = 6;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 11.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(879, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Solutions Inc.";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // picDevFINITY
            // 
            this.picDevFINITY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDevFINITY.ForeColor = System.Drawing.Color.Black;
            this.picDevFINITY.Image = global::DevFINITY.DigitalIdentity.Properties.Resources.devfinity;
            this.picDevFINITY.Location = new System.Drawing.Point(826, 14);
            this.picDevFINITY.MaximumSize = new System.Drawing.Size(48, 48);
            this.picDevFINITY.MinimumSize = new System.Drawing.Size(48, 48);
            this.picDevFINITY.Name = "picDevFINITY";
            this.picDevFINITY.Size = new System.Drawing.Size(48, 48);
            this.picDevFINITY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDevFINITY.TabIndex = 8;
            this.picDevFINITY.TabStop = false;
            this.picDevFINITY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // lblDigitalIdentity
            // 
            this.lblDigitalIdentity.AutoSize = true;
            this.lblDigitalIdentity.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitalIdentity.ForeColor = System.Drawing.Color.Black;
            this.lblDigitalIdentity.Location = new System.Drawing.Point(63, 18);
            this.lblDigitalIdentity.Name = "lblDigitalIdentity";
            this.lblDigitalIdentity.Size = new System.Drawing.Size(191, 40);
            this.lblDigitalIdentity.TabIndex = 8;
            this.lblDigitalIdentity.Text = "Digital Identity";
            this.lblDigitalIdentity.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // picFingerprint
            // 
            this.picFingerprint.ForeColor = System.Drawing.Color.Black;
            this.picFingerprint.Image = global::DevFINITY.DigitalIdentity.Properties.Resources.fingerprint;
            this.picFingerprint.Location = new System.Drawing.Point(12, 14);
            this.picFingerprint.MaximumSize = new System.Drawing.Size(48, 48);
            this.picFingerprint.MinimumSize = new System.Drawing.Size(48, 48);
            this.picFingerprint.Name = "picFingerprint";
            this.picFingerprint.Size = new System.Drawing.Size(48, 48);
            this.picFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFingerprint.TabIndex = 7;
            this.picFingerprint.TabStop = false;
            this.picFingerprint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // lblDevFINITY
            // 
            this.lblDevFINITY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDevFINITY.AutoSize = true;
            this.lblDevFINITY.Font = new System.Drawing.Font("Segoe UI Light", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevFINITY.ForeColor = System.Drawing.Color.Black;
            this.lblDevFINITY.Location = new System.Drawing.Point(876, 12);
            this.lblDevFINITY.Name = "lblDevFINITY";
            this.lblDevFINITY.Size = new System.Drawing.Size(126, 35);
            this.lblDevFINITY.TabIndex = 9;
            this.lblDevFINITY.Text = "DevFINITY";
            this.lblDevFINITY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.ForeColor = System.Drawing.Color.Black;
            this.minimizeButton.IconPressedColor = System.Drawing.Color.Snow;
            this.minimizeButton.Location = new System.Drawing.Point(922, 4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(32, 26);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimizeButton.Type = SwingWERX.Controls.ButtonType.MINIMIZE;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeAction);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.ForeColor = System.Drawing.Color.Black;
            this.maximizeButton.IconPressedColor = System.Drawing.Color.Snow;
            this.maximizeButton.Location = new System.Drawing.Point(955, 4);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(32, 26);
            this.maximizeButton.TabIndex = 1;
            this.maximizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.maximizeButton.Type = SwingWERX.Controls.ButtonType.MAXIMIZE;
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.ToggleSizeAction);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.IconPressedColor = System.Drawing.Color.Snow;
            this.closeButton.Location = new System.Drawing.Point(988, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 26);
            this.closeButton.TabIndex = 0;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Type = SwingWERX.Controls.ButtonType.CLOSE;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseAction);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoadEvent);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.mainPanel.ResumeLayout(false);
            this.panelManager.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDevFINITY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerprint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.DotNetBar.PanelEx mainPanel;
        private SwingWERX.Controls.FormButton closeButton;
        private SwingWERX.Controls.FormButton minimizeButton;
        private SwingWERX.Controls.FormButton maximizeButton;
        private DevComponents.DotNetBar.PanelEx headerPanel;
        private System.Windows.Forms.PictureBox picFingerprint;
        private System.Windows.Forms.Label lblDigitalIdentity;
        private System.Windows.Forms.PictureBox picDevFINITY;
        private SwingWERX.Controls.PanelManager panelManager;
        private SwingWERX.Controls.ManagedPanel loginPanel;
        private SwingWERX.Controls.ManagedPanel managedPanel2;
        private System.Windows.Forms.Label lblDevFINITY;
        private System.Windows.Forms.Label label1;
        private Controls.TileButton tileButton1;
    }
}

