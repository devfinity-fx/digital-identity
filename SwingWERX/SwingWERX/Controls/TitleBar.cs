using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using SwingWERX.Designers;

namespace SwingWERX.Controls
{
    [Docking(DockingBehavior.AutoDock), Designer(typeof(TitleBarDesigner))]
    public class TitleBar : FlowLayoutPanel
    {
        private FlowLayoutPanel basePanel = new FlowLayoutPanel();
        private List<FormButton> buttonList = new List<FormButton>();

        public TitleBar()
        {
            this.Type = TitleBarType.Default;

            this.FindForm();
        }

        public override System.Windows.Forms.Layout.LayoutEngine LayoutEngine
        {
            get
            {
                basePanel.FlowDirection = FlowDirection.RightToLeft;
                return basePanel.LayoutEngine;
            }
        }

        public override DockStyle Dock
        {
            get
            {
                return DockStyle.Top;
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }

        private void UpdateButtons()
        {
            FormButton button;
            switch (_type)
            {
                case TitleBarType.CloseOnly:
                    buttonList.Clear();

                    button = new FormButton() { Margin = new Padding(0,0,0,0) };
                    button.Type = ButtonType.CLOSE;

                    buttonList.Add(button);

                    break;
                case TitleBarType.CloseMinimize:
                    buttonList.Clear();

                    button = new FormButton() { Margin = new Padding(0, 0, 0, 0) };
                    button.Type = ButtonType.CLOSE;

                    buttonList.Add(button);

                    button = new FormButton() { Margin = new Padding(0, 0, 0, 0) };
                    button.Type = ButtonType.MINIMIZE;

                    buttonList.Add(button);

                    break;
                case TitleBarType.CloseQuestion:
                    buttonList.Clear();

                    button = new FormButton() { Margin = new Padding(0, 0, 0, 0) };
                    button.Type = ButtonType.CLOSE;

                    buttonList.Add(button);

                    button = new FormButton() { Margin = new Padding(0, 0, 0, 0) };
                    button.Type = ButtonType.QUESTION;

                    buttonList.Add(button);

                    break;
                case TitleBarType.Full:

                    buttonList.Clear();

                    button = new FormButton() { Margin = new Padding(0,0,0,0) };
                    button.Type = ButtonType.CLOSE;

                    buttonList.Add(button);

                    button = new FormButton() { Margin = new Padding(0,0,0,0) };
                    button.Type = ButtonType.MAXIMIZE;

                    buttonList.Add(button);

                    button = new FormButton() { Margin = new Padding(0,0,0,0) };
                    button.Type = ButtonType.MINIMIZE;

                    buttonList.Add(button);
 
                    button = new FormButton() { Margin = new Padding(0,0,0,0) };
                    button.Type = ButtonType.QUESTION;

                    buttonList.Add(button);
                    break;
                default:
                    buttonList.Clear();

                    button = new FormButton() { Margin = new Padding(0,0,0,0) };
                    button.Type = ButtonType.CLOSE;

                    buttonList.Add(button);

                    button = new FormButton() { Margin = new Padding(0,0,0,0) };
                    button.Type = ButtonType.MAXIMIZE;

                    buttonList.Add(button);

                    button = new FormButton() { Margin = new Padding(0,0,0,0) };
                    button.Type = ButtonType.MINIMIZE;

                    buttonList.Add(button);
                    break;
            }

            this.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;

            this.Controls.Clear();
            for (int i = 0; i < buttonList.Count; i++)
            {
                this.Controls.Add(buttonList[i]);
            }
        }


        public override System.Drawing.Size MinimumSize
        {
            get
            {
                return new System.Drawing.Size(0, 28);
            }
        }

        public override System.Drawing.Size MaximumSize
        {
            get
            {
                return new System.Drawing.Size(0, 28);
            }
        }

        protected override System.Drawing.Size DefaultSize
        {
            get
            {
                return new System.Drawing.Size(0, 28);
            }
        }


        private TitleBarType _type = TitleBarType.Default;
        [PropertyTab("TitleBarType")]
        [DisplayName("TitleBarType")]
        [Description("The buttons to be displayed by the TitleBar.")]
        [Category("Appearance")]
        [Browsable(true)]
        [DefaultValue(TitleBarType.Default)]
        public TitleBarType Type
        {
            get { return _type; }
            set { _type = value; UpdateButtons(); }
        }
    }

    public enum TitleBarType
    {
        CloseQuestion = 0,
        CloseOnly = 1,
        CloseMinimize = 2,
        Default = 3,
        Full = 4
    }
}
