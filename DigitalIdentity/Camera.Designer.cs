namespace DevFINITY.DigitalIdentity
{
    partial class Camera
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.mainPanel = new DevComponents.DotNetBar.PanelEx();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new SwingWERX.Controls.FormButton(this.components);
            this.cmbCameraList = new Telerik.WinControls.UI.RadDropDownList();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCameraList)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(55)))), ((int)(((byte)(58))))));
            // 
            // mainPanel
            // 
            this.mainPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.mainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mainPanel.Controls.Add(this.buttonX1);
            this.mainPanel.Controls.Add(this.cmbCameraList);
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Controls.Add(this.pictureBox);
            this.mainPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(280, 432);
            this.mainPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mainPanel.Style.BackColor1.Color = System.Drawing.Color.White;
            this.mainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mainPanel.Style.BorderWidth = 0;
            this.mainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mainPanel.Style.GradientAngle = 90;
            this.mainPanel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.ForeColor = System.Drawing.Color.Black;
            this.pictureBox.Location = new System.Drawing.Point(12, 104);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(256, 256);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.IconPressedColor = System.Drawing.Color.Snow;
            this.closeButton.Location = new System.Drawing.Point(245, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 26);
            this.closeButton.TabIndex = 3;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.Type = SwingWERX.Controls.ButtonType.CLOSE;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // cmbCameraList
            // 
            this.cmbCameraList.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbCameraList.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F);
            this.cmbCameraList.ForeColor = System.Drawing.Color.Black;
            this.cmbCameraList.Location = new System.Drawing.Point(12, 63);
            this.cmbCameraList.Name = "cmbCameraList";
            this.cmbCameraList.Size = new System.Drawing.Size(256, 31);
            this.cmbCameraList.TabIndex = 4;
            this.cmbCameraList.Text = "radDropDownList1";
            this.cmbCameraList.ThemeName = "Office2013Light";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F);
            this.buttonX1.Location = new System.Drawing.Point(12, 372);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(256, 48);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 5;
            this.buttonX1.Text = "Capture";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 432);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Camera";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotNetBar Metro App Form";
            this.Load += new System.EventHandler(this.LoadEvent);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCameraList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.PanelEx mainPanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private SwingWERX.Controls.FormButton closeButton;
        private Telerik.WinControls.UI.RadDropDownList cmbCameraList;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}

