namespace DevFINITY.DigitalIdentity
{
    partial class RetinaScan
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
            this.cameraRetina = new Emgu.CV.UI.ImageBox();
            this.btnCapture = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.cameraRetina)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraRetina
            // 
            this.cameraRetina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cameraRetina.ForeColor = System.Drawing.Color.Black;
            this.cameraRetina.Location = new System.Drawing.Point(4, 4);
            this.cameraRetina.Name = "cameraRetina";
            this.cameraRetina.Size = new System.Drawing.Size(202, 202);
            this.cameraRetina.TabIndex = 2;
            this.cameraRetina.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCapture.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCapture.Location = new System.Drawing.Point(4, 212);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(202, 26);
            this.btnCapture.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCapture.TabIndex = 3;
            this.btnCapture.Text = "Capture";
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // RetinaScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 242);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.cameraRetina);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RetinaScan";
            this.Text = "DotNetBar Metro App Form";
            ((System.ComponentModel.ISupportInitialize)(this.cameraRetina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox cameraRetina;
        private DevComponents.DotNetBar.ButtonX btnCapture;
    }
}

