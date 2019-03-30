namespace SwingWERX.Editors
{
    partial class ToolTipEditorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new SwingWERX.Controls.SwxButton();
            this.txtMessage = new SwingWERX.Controls.InputBox(this.components);
            this.separator2 = new SwingWERX.Controls.Separator();
            this.txtHeader = new SwingWERX.Controls.InputBox(this.components);
            this.separator1 = new SwingWERX.Controls.Separator();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Controls.Add(this.separator2);
            this.panel1.Controls.Add(this.txtHeader);
            this.panel1.Controls.Add(this.separator1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 207);
            this.panel1.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.ColorMotif = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.btnOk.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.btnOk.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOk.Location = new System.Drawing.Point(12, 172);
            this.btnOk.Name = "btnOk";
            this.btnOk.PressedImage = null;
            this.btnOk.Size = new System.Drawing.Size(248, 25);
            this.btnOk.TabIndex = 4;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.txtMessage.Location = new System.Drawing.Point(12, 89);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.NullText = null;
            this.txtMessage.Size = new System.Drawing.Size(248, 74);
            this.txtMessage.TabIndex = 3;
            // 
            // separator2
            // 
            this.separator2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.separator2.Location = new System.Drawing.Point(12, 66);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(248, 17);
            this.separator2.TabIndex = 2;
            this.separator2.Text = "ToolTip Text";
            // 
            // txtHeader
            // 
            this.txtHeader.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.txtHeader.Location = new System.Drawing.Point(12, 35);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.NullText = null;
            this.txtHeader.Size = new System.Drawing.Size(248, 25);
            this.txtHeader.TabIndex = 1;
            // 
            // separator1
            // 
            this.separator1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.separator1.Location = new System.Drawing.Point(12, 12);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(248, 17);
            this.separator1.TabIndex = 0;
            this.separator1.Text = "Header Text";
            // 
            // ToolTipEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 207);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToolTipEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ToolTip Editor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Controls.Separator separator1;
        private Controls.Separator separator2;
        private Controls.InputBox txtHeader;
        private Controls.InputBox txtMessage;
        private Controls.SwxButton btnOk;
    }
}