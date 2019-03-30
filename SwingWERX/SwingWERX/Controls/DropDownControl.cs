using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Drawing;



namespace SwingWERX.Controls
{

    public partial class DropDownControl : Control
    {
        public enum eDockSide
        {
            Left,
            Right
        }

        public enum eDropState
        {
            Closed,
            Closing,
            Dropping,
            Dropped
        }

        DropDownContainer dropContainer;
        Control _dropDownItem;
        bool closedWhileInControl;
        private Size storedSize;

        private eDropState _dropState;
        protected eDropState DropState
        {
            get { return _dropState; }
        }


        public DropDownControl()
        {
            this.storedSize = this.Size;
            this.BackColor = Color.White;
            this.Text = this.Name;
        }

        public void InitializeDropDown(Control dropDownItem)
        {
            if (_dropDownItem != null)
                throw new Exception("The drop down item has already been implemented!");
            _DesignView = false;
            _dropState = eDropState.Closed;
            this.Size = _AnchorSize;
            this._AnchorClientBounds = new Rectangle(2, 2, _AnchorSize.Width - 21, _AnchorSize.Height - 4);
            //removes the dropDown item from the controls list so it 
            //won't be seen until the drop-down window is active
            if (this.Controls.Contains(dropDownItem))
                this.Controls.Remove(dropDownItem);
            _dropDownItem = dropDownItem;
        }

        private Size _AnchorSize = new Size(121, 21);
        public Size AnchorSize
        {
            get { return _AnchorSize; }
            set
            {
                _AnchorSize = value;
                this.Invalidate();
            }
        }

        private eDockSide _DockSide;
        public eDockSide DockSide
        {
            get { return _DockSide; }
            set { _DockSide = value; }
        }


        private bool _DesignView = true;
        [DefaultValue(false)]
        protected bool DesignView
        {
            get { return _DesignView; }
            set
            {
                if (_DesignView == value) return;

                _DesignView = value;
                if (_DesignView)
                {
                    this.Size = storedSize;
                }
                else
                {
                    storedSize = this.Size;
                    this.Size = _AnchorSize;
                }

            }
        }

        public event EventHandler PropertyChanged;
        protected void OnPropertyChanged()
        {
            if (PropertyChanged != null)
                PropertyChanged(null, null);
        }

        private Rectangle _AnchorClientBounds;
        public Rectangle AnchorClientBounds
        {
            get { return _AnchorClientBounds; }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (_DesignView)
                storedSize = this.Size;
            _AnchorSize.Width = this.Width;
            if (!_DesignView)
            {
                _AnchorSize.Height = this.Height;
                this._AnchorClientBounds = new Rectangle(2, 2, _AnchorSize.Width - 21, _AnchorSize.Height - 4);
            }
        }

        protected bool mousePressed;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            mousePressed = true;
            OpenDropDown();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            mousePressed = false;
            this.Invalidate();
        }

        protected virtual bool CanDrop
        {
            get
            {
                if (dropContainer != null)
                    return false;

                if (dropContainer == null && closedWhileInControl)
                {
                    closedWhileInControl = false;
                    return false;
                }

                return !closedWhileInControl;
            }
        }

        protected void OpenDropDown()
        {
            if (_dropDownItem == null)
                throw new NotImplementedException("The drop down item has not been initialized!  Use the InitializeDropDown() method to do so.");

            if (!CanDrop) return;

            dropContainer = new DropDownContainer(_dropDownItem);
            dropContainer.Bounds = GetDropDownBounds();
            dropContainer.DropStateChange += new DropDownContainer.DropWindowArgs(dropContainer_DropStateChange);
            dropContainer.FormClosed += new FormClosedEventHandler(dropContainer_Closed);
            this.Parent.Move += new EventHandler(ParentForm_Move);
            _dropState = eDropState.Dropping;
            dropContainer.Show(this);
            _dropState = eDropState.Dropped;
            this.Invalidate();
        }

        void ParentForm_Move(object sender, EventArgs e)
        {
            dropContainer.Bounds = GetDropDownBounds();
        }


        public void CloseDropDown()
        {

            if (dropContainer != null)
            {
                _dropState = eDropState.Closing;
                dropContainer.Freeze = false;
                dropContainer.Close();
            }
        }

        void dropContainer_DropStateChange(DropDownControl.eDropState state)
        {
            _dropState = state;
        }
        void dropContainer_Closed(object sender, FormClosedEventArgs e)
        {
            if (!dropContainer.IsDisposed)
            {
                dropContainer.DropStateChange -= dropContainer_DropStateChange;
                dropContainer.FormClosed -= dropContainer_Closed;
                this.Parent.Move -= ParentForm_Move;
                dropContainer.Dispose();
            }
            dropContainer = null;
            closedWhileInControl = (this.RectangleToScreen(this.ClientRectangle).Contains(Cursor.Position));
            _dropState = eDropState.Closed;
            this.Invalidate();
        }

        protected virtual Rectangle GetDropDownBounds()
        {
            Size inflatedDropSize = new Size(_dropDownItem.Width + 2, _dropDownItem.Height + 2);
            Rectangle screenBounds = _DockSide == eDockSide.Left ?
                new Rectangle(this.Parent.PointToScreen(new Point(this.Bounds.X, this.Bounds.Bottom)), inflatedDropSize)
                : new Rectangle(this.Parent.PointToScreen(new Point(this.Bounds.Right - _dropDownItem.Width, this.Bounds.Bottom)), inflatedDropSize);
            Rectangle workingArea = Screen.GetWorkingArea(screenBounds);
            //make sure we're completely in the top-left working area
            if (screenBounds.X < workingArea.X) screenBounds.X = workingArea.X;
            if (screenBounds.Y < workingArea.Y) screenBounds.Y = workingArea.Y;

            //make sure we're not extended past the working area's right /bottom edge
            if (screenBounds.Right > workingArea.Right && workingArea.Width > screenBounds.Width)
                screenBounds.X = workingArea.Right - screenBounds.Width;
            if (screenBounds.Bottom > workingArea.Bottom && workingArea.Height > screenBounds.Height)
                screenBounds.Y = workingArea.Bottom - screenBounds.Height;

            return screenBounds;
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Check if VisualStyles are supported...
            //Thanks to codeproject member: Mathiyazhagan for catching this. :)
            if (ComboBoxRenderer.IsSupported && TextBoxRenderer.IsSupported)
            {

                TextFormatFlags flag = TextFormatFlags.TextBoxControl | TextFormatFlags.SingleLine;

                Rectangle textRect = new Rectangle(new Point(2, 2), _AnchorSize);
                TextBoxRenderer.DrawTextBox(e.Graphics, new Rectangle(new Point(0, 0), _AnchorSize), this.Text, this.Font, textRect, System.Windows.Forms.VisualStyles.TextBoxState.Normal);
                //TextBoxRenderer.DrawTextBox(e.Graphics, new Rectangle(new Point(0, 0), _AnchorSize), this.Text, this.Font, textRect, flag, getState());
                ComboBoxRenderer.DrawDropDownButton(e.Graphics, new Rectangle(_AnchorSize.Width - 19, 2, 18, _AnchorSize.Height - 4), getState());
            }
            else
            {
                ControlPaint.DrawComboButton(e.Graphics, new Rectangle(
                    _AnchorSize.Width - 19, 2, 18, _AnchorSize.Height - 4),
                    (this.Enabled) ? System.Windows.Forms.ButtonState.Normal : System.Windows.Forms.ButtonState.Inactive);
            }

            using (Brush b = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillRectangle(b, this.AnchorClientBounds);
            }
            Rectangle rect = new Rectangle(0, 0, this.AnchorClientBounds.Width, this.AnchorClientBounds.Height - 2);
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, rect, this.ForeColor, TextFormatFlags.WordEllipsis | TextFormatFlags.VerticalCenter);
            
        }

        private System.Windows.Forms.VisualStyles.ComboBoxState getState()
        {
            return System.Windows.Forms.VisualStyles.ComboBoxState.Normal;
        }

        public void FreezeDropDown(bool remainVisible)
        {
            if (dropContainer != null)
            {
                dropContainer.Freeze = true;
                if (!remainVisible)
                    dropContainer.Visible = false;
            }
        }

        public void UnFreezeDropDown()
        {
            if (dropContainer != null)
            {
                dropContainer.Freeze = false;
                if (!dropContainer.Visible)
                    dropContainer.Visible = true;
            }
        }

        internal sealed class DropDownContainer : Form, IMessageFilter
        {
            public bool Freeze;


            public DropDownContainer(Control dropDownItem)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                dropDownItem.Location = new Point(1, 1);
                this.Controls.Add(dropDownItem);
                this.StartPosition = FormStartPosition.Manual;
                this.ShowInTaskbar = false;
                Application.AddMessageFilter(this);
            }

            public bool PreFilterMessage(ref Message m)
            {
                if (!Freeze && this.Visible && (Form.ActiveForm == null || !Form.ActiveForm.Equals(this)))
                {
                    OnDropStateChange(eDropState.Closing);
                    this.Close();
                }


                return false;
            }

            public delegate void DropWindowArgs(eDropState state);
            public event DropWindowArgs DropStateChange;
            protected void OnDropStateChange(eDropState state)
            {
                if (DropStateChange != null)
                    DropStateChange(state);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                e.Graphics.DrawRectangle(Pens.Gray, new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1));
            }

            protected override void OnClosing(CancelEventArgs e)
            {
                Application.RemoveMessageFilter(this);
                this.Controls.RemoveAt(0); //prevent the control from being disposed
                base.OnClosing(e);
            }
        }
    }

}
