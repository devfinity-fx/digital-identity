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
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.mainPanel = new DevComponents.DotNetBar.PanelEx();
            this.tileButton1 = new DevFINITY.DigitalIdentity.Controls.TileButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(55)))), ((int)(((byte)(58))))));
            // 
            // mainPanel
            // 
            this.mainPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.mainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mainPanel.Controls.Add(this.tileButton1);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(309, 455);
            this.mainPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mainPanel.Style.BackColor1.Color = System.Drawing.Color.White;
            this.mainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mainPanel.Style.BorderWidth = 0;
            this.mainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mainPanel.Style.GradientAngle = 90;
            this.mainPanel.TabIndex = 0;
            // 
            // tileButton1
            // 
            this.tileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tileButton1.FlatAppearance.BorderSize = 0;
            this.tileButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton1.ForeColor = System.Drawing.Color.Black;
            this.tileButton1.Image = global::DevFINITY.DigitalIdentity.Properties.Resources.camera;
            this.tileButton1.Location = new System.Drawing.Point(112, 313);
            this.tileButton1.Name = "tileButton1";
            this.tileButton1.Size = new System.Drawing.Size(85, 130);
            this.tileButton1.TabIndex = 1;
            this.tileButton1.Text = "Capture";
            this.tileButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ForeColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(26, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 455);
            this.CloseBoxVisible = false;
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Camera";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.DotNetBar.PanelEx mainPanel;
        private Controls.TileButton tileButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

