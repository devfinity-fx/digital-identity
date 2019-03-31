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
            this.mainPanelEx = new DevComponents.DotNetBar.PanelEx();
            this.panelManager = new SwingWERX.Controls.PanelManager();
            this.loginManagedPanel = new SwingWERX.Controls.ManagedPanel();
            this.menuManagedPanel = new SwingWERX.Controls.ManagedPanel();
            this.menuPanelEx = new DevComponents.DotNetBar.PanelEx();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.separator1 = new SwingWERX.Controls.Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.headerPanel = new DevComponents.DotNetBar.PanelEx();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDigitalIdentity = new System.Windows.Forms.Label();
            this.lblDevFINITY = new System.Windows.Forms.Label();
            this.minimizeButton = new SwingWERX.Controls.FormButton(this.components);
            this.closeButton = new SwingWERX.Controls.FormButton(this.components);
            this.btnLogin = new DevFINITY.DigitalIdentity.Controls.TileButton();
            this.tileButton1 = new DevFINITY.DigitalIdentity.Controls.TileButton();
            this.tileButton3 = new DevFINITY.DigitalIdentity.Controls.TileButton();
            this.tileButton2 = new DevFINITY.DigitalIdentity.Controls.TileButton();
            this.picDevFINITY = new System.Windows.Forms.PictureBox();
            this.picFingerprint = new System.Windows.Forms.PictureBox();
            this.mainPanelEx.SuspendLayout();
            this.panelManager.SuspendLayout();
            this.loginManagedPanel.SuspendLayout();
            this.menuManagedPanel.SuspendLayout();
            this.menuPanelEx.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDevFINITY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerprint)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(55)))), ((int)(((byte)(58))))));
            // 
            // mainPanelEx
            // 
            this.mainPanelEx.CanvasColor = System.Drawing.SystemColors.Control;
            this.mainPanelEx.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mainPanelEx.Controls.Add(this.panelManager);
            this.mainPanelEx.Controls.Add(this.headerPanel);
            this.mainPanelEx.Controls.Add(this.minimizeButton);
            this.mainPanelEx.Controls.Add(this.closeButton);
            this.mainPanelEx.DisabledBackColor = System.Drawing.Color.Empty;
            this.mainPanelEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanelEx.Location = new System.Drawing.Point(0, 0);
            this.mainPanelEx.Name = "mainPanelEx";
            this.mainPanelEx.Size = new System.Drawing.Size(1024, 768);
            this.mainPanelEx.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mainPanelEx.Style.BackColor1.Color = System.Drawing.Color.White;
            this.mainPanelEx.Style.BackColor2.Color = System.Drawing.Color.White;
            this.mainPanelEx.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mainPanelEx.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mainPanelEx.Style.BorderWidth = 0;
            this.mainPanelEx.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mainPanelEx.Style.GradientAngle = 90;
            this.mainPanelEx.TabIndex = 2;
            this.mainPanelEx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            // 
            // panelManager
            // 
            this.panelManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelManager.Controls.Add(this.loginManagedPanel);
            this.panelManager.Controls.Add(this.menuManagedPanel);
            this.panelManager.ForeColor = System.Drawing.Color.Black;
            this.panelManager.Location = new System.Drawing.Point(0, 108);
            this.panelManager.Name = "panelManager";
            this.panelManager.SelectedIndex = 1;
            this.panelManager.SelectedPanel = this.menuManagedPanel;
            this.panelManager.Size = new System.Drawing.Size(1024, 660);
            this.panelManager.TabIndex = 7;
            // 
            // loginManagedPanel
            // 
            this.loginManagedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginManagedPanel.Controls.Add(this.btnLogin);
            this.loginManagedPanel.ForeColor = System.Drawing.Color.Black;
            this.loginManagedPanel.Location = new System.Drawing.Point(0, 0);
            this.loginManagedPanel.Margin = new System.Windows.Forms.Padding(0);
            this.loginManagedPanel.Name = "loginManagedPanel";
            this.loginManagedPanel.Size = new System.Drawing.Size(1024, 660);
            // 
            // menuManagedPanel
            // 
            this.menuManagedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuManagedPanel.Controls.Add(this.menuPanelEx);
            this.menuManagedPanel.Controls.Add(this.panelEx1);
            this.menuManagedPanel.ForeColor = System.Drawing.Color.Black;
            this.menuManagedPanel.Location = new System.Drawing.Point(0, 0);
            this.menuManagedPanel.Name = "menuManagedPanel";
            this.menuManagedPanel.Size = new System.Drawing.Size(1024, 660);
            this.menuManagedPanel.Text = "managedPanel2";
            // 
            // menuPanelEx
            // 
            this.menuPanelEx.CanvasColor = System.Drawing.SystemColors.Control;
            this.menuPanelEx.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.menuPanelEx.Controls.Add(this.panelEx3);
            this.menuPanelEx.DisabledBackColor = System.Drawing.Color.Empty;
            this.menuPanelEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanelEx.Location = new System.Drawing.Point(0, 0);
            this.menuPanelEx.Name = "menuPanelEx";
            this.menuPanelEx.Size = new System.Drawing.Size(1024, 575);
            this.menuPanelEx.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.menuPanelEx.Style.BackColor1.Color = System.Drawing.Color.White;
            this.menuPanelEx.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.menuPanelEx.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.menuPanelEx.Style.BorderWidth = 0;
            this.menuPanelEx.Style.ForeColor.Color = System.Drawing.Color.Silver;
            this.menuPanelEx.Style.GradientAngle = 90;
            this.menuPanelEx.TabIndex = 8;
            // 
            // panelEx3
            // 
            this.panelEx3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.separator1);
            this.panelEx3.Controls.Add(this.tileButton1);
            this.panelEx3.Controls.Add(this.label2);
            this.panelEx3.Controls.Add(this.tileButton3);
            this.panelEx3.Controls.Add(this.tileButton2);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Location = new System.Drawing.Point(10, 293);
            this.panelEx3.Margin = new System.Windows.Forms.Padding(10);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(1004, 277);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.Color = System.Drawing.Color.White;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.BorderWidth = 0;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 7;
            // 
            // separator1
            // 
            this.separator1.ForeColor = System.Drawing.Color.Black;
            this.separator1.Location = new System.Drawing.Point(276, 40);
            this.separator1.Name = "separator1";
            this.separator1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.separator1.Size = new System.Drawing.Size(23, 228);
            this.separator1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 22F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 82);
            this.label2.TabIndex = 3;
            this.label2.Text = "RECORD\r\nMANAGEMENT";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 575);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1024, 85);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.BorderWidth = 0;
            this.panelEx1.Style.ForeColor.Color = System.Drawing.Color.Silver;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI Semilight", 10.25F);
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(16, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.Color.Silver;
            this.labelX1.Size = new System.Drawing.Size(468, 39);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Copyright © 2018-2019 DevFINITY Solutions, Inc.\r\nAll trademarks or registered tra" +
    "demarks are property of their respective owners.";
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
            this.minimizeButton.Location = new System.Drawing.Point(955, 4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(32, 26);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimizeButton.Type = SwingWERX.Controls.ButtonType.MINIMIZE;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeAction);
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
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Image = global::DevFINITY.DigitalIdentity.Properties.Resources.add_fingerprint;
            this.btnLogin.Location = new System.Drawing.Point(470, 480);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 130);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.LoginAction);
            // 
            // tileButton1
            // 
            this.tileButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tileButton1.FlatAppearance.BorderSize = 0;
            this.tileButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton1.ForeColor = System.Drawing.Color.Black;
            this.tileButton1.Image = global::DevFINITY.DigitalIdentity.Properties.Resources.add_user;
            this.tileButton1.Location = new System.Drawing.Point(3, 138);
            this.tileButton1.Name = "tileButton1";
            this.tileButton1.Size = new System.Drawing.Size(85, 130);
            this.tileButton1.TabIndex = 4;
            this.tileButton1.Text = "Add Record";
            this.tileButton1.UseVisualStyleBackColor = false;
            // 
            // tileButton3
            // 
            this.tileButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tileButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tileButton3.FlatAppearance.BorderSize = 0;
            this.tileButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton3.ForeColor = System.Drawing.Color.Black;
            this.tileButton3.Image = global::DevFINITY.DigitalIdentity.Properties.Resources.manage_user;
            this.tileButton3.Location = new System.Drawing.Point(185, 138);
            this.tileButton3.Name = "tileButton3";
            this.tileButton3.Size = new System.Drawing.Size(85, 130);
            this.tileButton3.TabIndex = 2;
            this.tileButton3.Text = "Manage Records";
            this.tileButton3.UseVisualStyleBackColor = false;
            // 
            // tileButton2
            // 
            this.tileButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tileButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tileButton2.FlatAppearance.BorderSize = 0;
            this.tileButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton2.ForeColor = System.Drawing.Color.Black;
            this.tileButton2.Image = global::DevFINITY.DigitalIdentity.Properties.Resources.search_user1;
            this.tileButton2.Location = new System.Drawing.Point(94, 138);
            this.tileButton2.Name = "tileButton2";
            this.tileButton2.Size = new System.Drawing.Size(85, 130);
            this.tileButton2.TabIndex = 1;
            this.tileButton2.Text = "Search Record";
            this.tileButton2.UseVisualStyleBackColor = false;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.mainPanelEx);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoadEvent);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.mainPanelEx.ResumeLayout(false);
            this.panelManager.ResumeLayout(false);
            this.loginManagedPanel.ResumeLayout(false);
            this.menuManagedPanel.ResumeLayout(false);
            this.menuPanelEx.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.panelEx3.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDevFINITY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerprint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.DotNetBar.PanelEx mainPanelEx;
        private SwingWERX.Controls.FormButton closeButton;
        private SwingWERX.Controls.FormButton minimizeButton;
        private DevComponents.DotNetBar.PanelEx headerPanel;
        private System.Windows.Forms.PictureBox picFingerprint;
        private System.Windows.Forms.Label lblDigitalIdentity;
        private System.Windows.Forms.PictureBox picDevFINITY;
        private SwingWERX.Controls.PanelManager panelManager;
        private SwingWERX.Controls.ManagedPanel loginManagedPanel;
        private SwingWERX.Controls.ManagedPanel menuManagedPanel;
        private System.Windows.Forms.Label lblDevFINITY;
        private System.Windows.Forms.Label label1;
        private Controls.TileButton btnLogin;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx menuPanelEx;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private System.Windows.Forms.Label label2;
        private Controls.TileButton tileButton3;
        private Controls.TileButton tileButton2;
        private Controls.TileButton tileButton1;
        private SwingWERX.Controls.Separator separator1;
    }
}

