namespace SwingWERX.Controls
{
    partial class ColorChooser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.colorListBox2 = new SwingWERX.Controls.ColorListBox();
            this.colorListBox1 = new SwingWERX.Controls.ColorListBox();
            this.colorPanel1 = new SwingWERX.Controls.ColorPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(202, 222);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.colorPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(194, 196);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Custom";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.colorListBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(194, 196);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Web";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.colorListBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(194, 196);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "System";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // colorListBox2
            // 
            this.colorListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorListBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorListBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colorListBox2.FormattingEnabled = true;
            this.colorListBox2.ItemHeight = 16;
            this.colorListBox2.Location = new System.Drawing.Point(0, 0);
            this.colorListBox2.Margin = new System.Windows.Forms.Padding(0);
            this.colorListBox2.Name = "colorListBox2";
            this.colorListBox2.Size = new System.Drawing.Size(194, 196);
            this.colorListBox2.TabIndex = 1;
            this.colorListBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MouseDoubleClick_Action);
            // 
            // colorListBox1
            // 
            this.colorListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colorListBox1.FormattingEnabled = true;
            this.colorListBox1.ItemHeight = 16;
            this.colorListBox1.Location = new System.Drawing.Point(0, 0);
            this.colorListBox1.Margin = new System.Windows.Forms.Padding(0);
            this.colorListBox1.Name = "colorListBox1";
            this.colorListBox1.Size = new System.Drawing.Size(194, 196);
            this.colorListBox1.TabIndex = 0;
            this.colorListBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MouseDoubleClick_Action);
            // 
            // colorPanel1
            // 
            this.colorPanel1.Location = new System.Drawing.Point(0, 0);
            this.colorPanel1.Name = "colorPanel1";
            this.colorPanel1.Size = new System.Drawing.Size(194, 196);
            this.colorPanel1.TabIndex = 0;
            this.colorPanel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MouseDoubleClick_Action);
            // 
            // ColorChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ColorChooser";
            this.Size = new System.Drawing.Size(202, 222);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private ColorListBox colorListBox1;
        private ColorListBox colorListBox2;
        private ColorPanel colorPanel1;
    }
}
