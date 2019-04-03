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
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.recordsManagedPanel = new SwingWERX.Controls.ManagedPanel();
            this.recordsPanelEx = new DevComponents.DotNetBar.PanelEx();
            this.addRecordManagedPanel = new SwingWERX.Controls.ManagedPanel();
            this.addRecordPanelEx = new DevComponents.DotNetBar.PanelEx();
            this.scrollPanel = new Telerik.WinControls.UI.RadScrollablePanel();
            this.minimizeButton = new SwingWERX.Controls.FormButton(this.components);
            this.closeButton = new SwingWERX.Controls.FormButton(this.components);
            this.headerPanel = new DevComponents.DotNetBar.PanelEx();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDigitalIdentity = new System.Windows.Forms.Label();
            this.lblDevFINITY = new System.Windows.Forms.Label();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.btnLogin = new DevFINITY.DigitalIdentity.Controls.TileButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrintRecord = new DevFINITY.DigitalIdentity.Controls.TileButton();
            this.btnAddRecord = new DevFINITY.DigitalIdentity.Controls.TileButton();
            this.buttonLabel1 = new SwingWERX.Controls.ButtonLabel();
            this.picDevFINITY = new System.Windows.Forms.PictureBox();
            this.picFingerprint = new System.Windows.Forms.PictureBox();
            this.contentPanel = new DevComponents.DotNetBar.PanelEx();
            this.mainPanelEx.SuspendLayout();
            this.panelManager.SuspendLayout();
            this.loginManagedPanel.SuspendLayout();
            this.menuManagedPanel.SuspendLayout();
            this.menuPanelEx.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.recordsManagedPanel.SuspendLayout();
            this.addRecordManagedPanel.SuspendLayout();
            this.addRecordPanelEx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scrollPanel)).BeginInit();
            this.scrollPanel.PanelContainer.SuspendLayout();
            this.scrollPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.mainPanelEx.Controls.Add(this.minimizeButton);
            this.mainPanelEx.Controls.Add(this.closeButton);
            this.mainPanelEx.Controls.Add(this.headerPanel);
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
            this.panelManager.Controls.Add(this.recordsManagedPanel);
            this.panelManager.Controls.Add(this.addRecordManagedPanel);
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
            this.loginManagedPanel.Size = new System.Drawing.Size(0, 0);
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
            this.menuPanelEx.Controls.Add(this.pictureBox1);
            this.menuPanelEx.Controls.Add(this.txtSearch);
            this.menuPanelEx.Controls.Add(this.btnPrintRecord);
            this.menuPanelEx.Controls.Add(this.btnAddRecord);
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
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.ButtonCustom.Symbol = "";
            this.txtSearch.ButtonCustom.Visible = true;
            this.txtSearch.DisabledBackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semilight", 18.25F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(262, 327);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PreventEnterBeep = true;
            this.txtSearch.Size = new System.Drawing.Size(500, 40);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.WatermarkText = "Search person...";
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
            // recordsManagedPanel
            // 
            this.recordsManagedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.recordsManagedPanel.Controls.Add(this.recordsPanelEx);
            this.recordsManagedPanel.ForeColor = System.Drawing.Color.Black;
            this.recordsManagedPanel.Location = new System.Drawing.Point(0, 0);
            this.recordsManagedPanel.Name = "recordsManagedPanel";
            this.recordsManagedPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // recordsPanelEx
            // 
            this.recordsPanelEx.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.recordsPanelEx.DisabledBackColor = System.Drawing.Color.Empty;
            this.recordsPanelEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordsPanelEx.Location = new System.Drawing.Point(0, 0);
            this.recordsPanelEx.Name = "recordsPanelEx";
            this.recordsPanelEx.Size = new System.Drawing.Size(0, 0);
            this.recordsPanelEx.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.recordsPanelEx.Style.BackColor1.Color = System.Drawing.Color.White;
            this.recordsPanelEx.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.recordsPanelEx.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.recordsPanelEx.Style.BorderWidth = 0;
            this.recordsPanelEx.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.recordsPanelEx.Style.GradientAngle = 90;
            this.recordsPanelEx.TabIndex = 0;
            // 
            // addRecordManagedPanel
            // 
            this.addRecordManagedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addRecordManagedPanel.Controls.Add(this.addRecordPanelEx);
            this.addRecordManagedPanel.ForeColor = System.Drawing.Color.Black;
            this.addRecordManagedPanel.Location = new System.Drawing.Point(0, 0);
            this.addRecordManagedPanel.Name = "addRecordManagedPanel";
            this.addRecordManagedPanel.Size = new System.Drawing.Size(1024, 660);
            this.addRecordManagedPanel.Text = "managedPanel1";
            // 
            // addRecordPanelEx
            // 
            this.addRecordPanelEx.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.addRecordPanelEx.Controls.Add(this.scrollPanel);
            this.addRecordPanelEx.Controls.Add(this.panelEx2);
            this.addRecordPanelEx.DisabledBackColor = System.Drawing.Color.Empty;
            this.addRecordPanelEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addRecordPanelEx.Location = new System.Drawing.Point(0, 0);
            this.addRecordPanelEx.Name = "addRecordPanelEx";
            this.addRecordPanelEx.Size = new System.Drawing.Size(1024, 660);
            this.addRecordPanelEx.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.addRecordPanelEx.Style.BackColor1.Color = System.Drawing.Color.White;
            this.addRecordPanelEx.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.addRecordPanelEx.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.addRecordPanelEx.Style.BorderWidth = 0;
            this.addRecordPanelEx.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.addRecordPanelEx.Style.GradientAngle = 90;
            this.addRecordPanelEx.TabIndex = 4;
            // 
            // scrollPanel
            // 
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.ForeColor = System.Drawing.Color.Black;
            this.scrollPanel.Location = new System.Drawing.Point(0, 0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Padding = new System.Windows.Forms.Padding(0);
            // 
            // scrollPanel.PanelContainer
            // 
            this.scrollPanel.PanelContainer.Controls.Add(this.contentPanel);
            this.scrollPanel.PanelContainer.ForeColor = System.Drawing.Color.Black;
            this.scrollPanel.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.scrollPanel.PanelContainer.Size = new System.Drawing.Size(1007, 575);
            this.scrollPanel.Size = new System.Drawing.Size(1024, 575);
            this.scrollPanel.TabIndex = 0;
            this.scrollPanel.ThemeName = "Office2013Light";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.scrollPanel.GetChildAt(0).GetChildAt(1))).Width = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.scrollPanel.GetChildAt(0).GetChildAt(1))).LeftWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.scrollPanel.GetChildAt(0).GetChildAt(1))).TopWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.scrollPanel.GetChildAt(0).GetChildAt(1))).RightWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.scrollPanel.GetChildAt(0).GetChildAt(1))).BottomWidth = 0F;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.scrollPanel.GetChildAt(0).GetChildAt(1))).Opacity = 0D;
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
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.buttonLabel1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx2.Location = new System.Drawing.Point(0, 575);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1024, 85);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.White;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.BorderWidth = 0;
            this.panelEx2.Style.ForeColor.Color = System.Drawing.Color.Silver;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 9;
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
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.LoginAction);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ForeColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::DevFINITY.DigitalIdentity.Properties.Resources.search_record;
            this.pictureBox1.Location = new System.Drawing.Point(384, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrintRecord
            // 
            this.btnPrintRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPrintRecord.FlatAppearance.BorderSize = 0;
            this.btnPrintRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintRecord.ForeColor = System.Drawing.Color.Black;
            this.btnPrintRecord.Image = global::DevFINITY.DigitalIdentity.Properties.Resources.print;
            this.btnPrintRecord.Location = new System.Drawing.Point(515, 381);
            this.btnPrintRecord.Name = "btnPrintRecord";
            this.btnPrintRecord.TabIndex = 11;
            this.btnPrintRecord.Text = "Print";
            this.btnPrintRecord.UseVisualStyleBackColor = false;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddRecord.FlatAppearance.BorderSize = 0;
            this.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecord.ForeColor = System.Drawing.Color.Black;
            this.btnAddRecord.Image = global::DevFINITY.DigitalIdentity.Properties.Resources.add_user;
            this.btnAddRecord.Location = new System.Drawing.Point(424, 381);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.TabIndex = 4;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = false;
            this.btnAddRecord.Click += new System.EventHandler(this.AddRecordAction);
            // 
            // buttonLabel1
            // 
            this.buttonLabel1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLabel1.ForeColor = System.Drawing.Color.Black;
            this.buttonLabel1.Image = global::DevFINITY.DigitalIdentity.Properties.Resources.save;
            this.buttonLabel1.ImageSize = new System.Drawing.Size(48, 48);
            this.buttonLabel1.Location = new System.Drawing.Point(480, 6);
            this.buttonLabel1.Name = "buttonLabel1";
            this.buttonLabel1.Size = new System.Drawing.Size(64, 72);
            this.buttonLabel1.TabIndex = 0;
            this.buttonLabel1.Text = "Save";
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
            // contentPanel
            // 
            this.contentPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.contentPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contentPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.contentPanel.Location = new System.Drawing.Point(1, 1);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1006, 685);
            this.contentPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.contentPanel.Style.BackColor1.Color = System.Drawing.Color.White;
            this.contentPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.contentPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.contentPanel.Style.BorderWidth = 0;
            this.contentPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.contentPanel.Style.GradientAngle = 90;
            this.contentPanel.TabIndex = 0;
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
            this.Text = " ";
            this.Load += new System.EventHandler(this.LoadEvent);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.mainPanelEx.ResumeLayout(false);
            this.panelManager.ResumeLayout(false);
            this.loginManagedPanel.ResumeLayout(false);
            this.menuManagedPanel.ResumeLayout(false);
            this.menuPanelEx.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.recordsManagedPanel.ResumeLayout(false);
            this.addRecordManagedPanel.ResumeLayout(false);
            this.addRecordPanelEx.ResumeLayout(false);
            this.scrollPanel.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scrollPanel)).EndInit();
            this.scrollPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Controls.TileButton btnAddRecord;
        private SwingWERX.Controls.ManagedPanel recordsManagedPanel;
        private DevComponents.DotNetBar.PanelEx recordsPanelEx;
        private Controls.TileButton btnPrintRecord;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SwingWERX.Controls.ManagedPanel addRecordManagedPanel;
        private DevComponents.DotNetBar.PanelEx addRecordPanelEx;
        private Telerik.WinControls.UI.RadScrollablePanel scrollPanel;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private SwingWERX.Controls.ButtonLabel buttonLabel1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private DevComponents.DotNetBar.PanelEx contentPanel;
    }
}

