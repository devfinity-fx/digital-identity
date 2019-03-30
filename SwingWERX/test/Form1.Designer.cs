namespace test
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorChooser1 = new SwingWERX.Controls.ColorChooser();
            this.dropDownControl1 = new SwingWERX.Controls.DropDownControl();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(49, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // colorChooser1
            // 
            this.colorChooser1.Location = new System.Drawing.Point(49, 268);
            this.colorChooser1.Name = "colorChooser1";
            this.colorChooser1.SelectedColor = System.Drawing.Color.Empty;
            this.colorChooser1.Size = new System.Drawing.Size(202, 222);
            this.colorChooser1.TabIndex = 2;
            this.colorChooser1.SelectedColorChanged += new System.EventHandler(this.ColorChooser_SelectedColorChanged);
            // 
            // dropDownControl1
            // 
            this.dropDownControl1.AnchorSize = new System.Drawing.Size(202, 21);
            this.dropDownControl1.BackColor = System.Drawing.Color.White;
            this.dropDownControl1.DockSide = SwingWERX.Controls.DropDownControl.eDockSide.Left;
            this.dropDownControl1.Location = new System.Drawing.Point(362, 95);
            this.dropDownControl1.Name = "dropDownControl1";
            this.dropDownControl1.Size = new System.Drawing.Size(202, 23);
            this.dropDownControl1.TabIndex = 0;
            this.dropDownControl1.Text = "dropDownControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 502);
            this.Controls.Add(this.colorChooser1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dropDownControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }



        #endregion

        private SwingWERX.Controls.DropDownControl dropDownControl1;
        private System.Windows.Forms.Panel panel1;
        private SwingWERX.Controls.ColorChooser colorChooser1;
    }
}

