namespace DevFINITY.DigitalIdentity
{
    partial class SnapshotForm
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
            this.btnSave = new DevFINITY.DigitalIdentity.Controls.BigTileButton();
            this.picCropped = new System.Windows.Forms.PictureBox();
            this.sfdPicture = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picCropped)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::DevFINITY.DigitalIdentity.Properties.Resources.save1;
            this.btnSave.Location = new System.Drawing.Point(12, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 71);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picCropped
            // 
            this.picCropped.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picCropped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCropped.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picCropped.Location = new System.Drawing.Point(12, 80);
            this.picCropped.Name = "picCropped";
            this.picCropped.Size = new System.Drawing.Size(480, 480);
            this.picCropped.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCropped.TabIndex = 5;
            this.picCropped.TabStop = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "JPEG images (*.jpg)|*.jpg|PNG images (*.png)|*.png|BMP images (*.bmp)|*.bmp";
            this.saveFileDialog.Title = "Save snapshot";
            // 
            // SnapshotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 571);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.picCropped);
            this.Name = "SnapshotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnapshotForm";
            ((System.ComponentModel.ISupportInitialize)(this.picCropped)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCropped;
        private Controls.BigTileButton btnSave;
        private System.Windows.Forms.SaveFileDialog sfdPicture;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}