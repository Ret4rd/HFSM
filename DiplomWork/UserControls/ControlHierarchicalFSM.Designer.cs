using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;

namespace DiplomWork.UserControls
{
    public partial class ControlHierarchicalFSM : IEnumerable
    {
        private FSM _fsm;
        public FSM fsm
        {
            get
            {
                return _fsm;
            }
        }

        public string ruleName; // имя скрипта

        public bool isHere;
        public bool isResize;

        private System.Drawing.Point _clickLocation;

        public ControlHierarchicalFSM link;

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
        /// 
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        private void InitializeComponent(MouseEventArgs e)
        {
            //this.panel = new System.Windows.Forms.Panel();
            this.components = new System.ComponentModel.Container();
            this.RuleName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // panel
            // 
            /*this.panel.Location = new System.Drawing.Point(0, 25);
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(250, 150);
            this.panel.TabIndex = 0;
            this.panel.BorderStyle = BorderStyle.Fixed3D;*/
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
            contextMenuStrip.Items.Add(deleteMenuItem);
            //this.ContextMenuStrip = contextMenuStrip;
            //deleteMenuItem.Click += deleteMenuItem_Click;
            // 
            // RuleName
            // 
            this.RuleName.Location = new System.Drawing.Point(5, 5);
            this.RuleName.Name = "RuleName";
            this.RuleName.Size = new System.Drawing.Size(240, 30);
            //this.RuleName.MaximumSize = new System.Drawing.Size(590, 20);
            this.RuleName.MinimumSize = new System.Drawing.Size(90, 30);
            this.RuleName.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(5, 5, RuleName.Width, RuleName.Height, 5, 5));
            this.RuleName.TextAlign = HorizontalAlignment.Center;
            this.RuleName.TextChanged += TextChanged;
            this.RuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
            this.RuleName.TabIndex = 0;
            // 
            // ControlHierarchicalFSM
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            //this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Controls.Add(this.RuleName);
            this.Location = new System.Drawing.Point(e.X, e.Y);
            this.Name = "ControlHierarchicalFSM";
            this.Size = new System.Drawing.Size(250, 150);
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        void deleteMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        protected void TextChanged(object sender, EventArgs e)
        {
            base.OnTextChanged(e);
            ruleName = this.RuleName.Text;
        }

        
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            //this.BorderStyle = BorderStyle.Fixed3D;
            isHere = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Cursor = Cursors.Default;
            //this.BorderStyle = BorderStyle.None;
            isHere = false;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if(Form.butFlag != 1)
            {
                return;
            }
            if(e.X > this.Size.Width - 10 &&
                e.Y > this.Size.Height - 10)
            {
                this.Cursor = Cursors.SizeNWSE;
            }
            else
            {
                this.Cursor = Cursors.SizeAll;
            }
            if (isResize && e.Button == MouseButtons.Left)//изменение размера
            {
                this.Size = new System.Drawing.Size(e.X, e.Y);
                this.RuleName.Size = new System.Drawing.Size(e.X - 10, 30);
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                this.RuleName.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(5, 5, RuleName.Width, RuleName.Height, 5, 5));
            }
            else if (e.Button == MouseButtons.Left)//перемещение
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - _clickLocation.X), this.Location.Y + (e.Y - _clickLocation.Y));
            }
            
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if(Form.butFlag == 2)
            {
                fsm.AddState(e);
                this.Controls.Add(fsm.GetLastState());
                

                /*ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
                deleteMenuItem.Click += deleteActionMenuItem_Click;
                this.Controls.Find().ContextMenuStrip = new ContextMenuStrip();
                this.buttonAddAction.ContextMenuStrip.Items.Add(deleteMenuItem);*/
            }
            else
            {
                //_clickLocation = e.Location;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _clickLocation = e.Location;
            if (e.Button == MouseButtons.Left && e.X > this.Size.Width - 10 &&
                e.Y > this.Size.Height - 10)
            {
                isResize = true;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        { 
            base.OnMouseUp(e);
            isResize = false;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }

        public IEnumerator GetEnumerator()
        {
            return _fsm.GetEnumerator();
        }

        private System.Windows.Forms.TextBox RuleName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
    }
}
