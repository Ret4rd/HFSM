using System;
using System.Windows.Forms;
using System.Collections.Generic;
using DiplomWork.TriggerForms;
using DiplomWork.ActionForms;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using DiplomWork.Triggers;
using DiplomWork.Actions;
using System.Collections;

namespace DiplomWork.UserControls
{
    partial class ControlStateFSM : IEnumerable
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private List<string> _whenList = new List<string> { "Устройство получило команду", "Устройство изменило состояние", "Устройство обновило состояние", "Фиксированное время" };

        public List<Trigger> whenBlock = new List<Trigger>();
        public List<MyAction> thenBlock = new List<MyAction>();

        private string _deviceWhen;
        private string _time;
        private string _prevState;
        private string _stateWhen;
        private string _deviceThen;
        private string _stateThen;

        private System.Drawing.Point _clickLocation;

        private int posBut;
        public List<ControlStateFSM> link;
        public bool firstState;

        private System.Drawing.Size btSize = new Size(180, 30);
        private System.Drawing.Point startBtTriggerSize = new Point(10, 10);
        private System.Drawing.Point startBtActionSize = new Point(10, 70);
        private System.Drawing.Point endBtTriggerSize = new Point(10, 10);
        private System.Drawing.Point endBtActionSize = new Point(10, 70);

        
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

        private void InitializeComponent(MouseEventArgs e, bool isFirst)
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxWhen = new System.Windows.Forms.ComboBox();
            this.comboBoxThen = new System.Windows.Forms.ComboBox();
            this.pictureBoxRemadeWhen = new System.Windows.Forms.PictureBox();
            this.pictureBoxRemadeThen = new System.Windows.Forms.PictureBox();
            this.buttonAddTrigger = new System.Windows.Forms.Button();
            this.buttonAddAction = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            //
            //components = new System.ComponentModel.Container();
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.PerformLayout();
            // 
            /*ToolStripMenuItem deleteThisMenuItem = new ToolStripMenuItem("Удалить");
            deleteThisMenuItem.Click += deleteMenuItem_Click;
            this.ContextMenuStrip = new ContextMenuStrip();
            this.ContextMenuStrip.Items.Add(deleteThisMenuItem);*/
            // comboBoxWhen
            // 
            /*this.comboBoxWhen.FormattingEnabled = true;
            this.comboBoxWhen.Location = new System.Drawing.Point(10, 10);
            this.comboBoxWhen.Name = "comboBoxWhen";
            this.comboBoxWhen.Size = new System.Drawing.Size(180, 15);
            this.comboBoxWhen.TabIndex = 0;
            this.comboBoxWhen.Text = "Переход";
            this.comboBoxWhen.SelectedIndexChanged += comboBoxWhen_SelectedIndexChanged;
            if (isFirst)
            {
                comboBoxWhen.Items.Add("Устройство получило команду");
                comboBoxWhen.Items.Add("Устройство изменило состояние");
                comboBoxWhen.Items.Add("Устройство обновило состояние");
                comboBoxWhen.Items.Add("Фиксированное время");
            }
            else
            {
                comboBoxWhen.Items.Add("Если состояние верно...");
            }
            // 
            // comboBoxThen
            // 
            this.comboBoxThen.FormattingEnabled = true;
            this.comboBoxThen.Location = new System.Drawing.Point(10, 70);
            this.comboBoxThen.Name = "comboBoxThen";
            this.comboBoxThen.Size = new System.Drawing.Size(180, 15);
            this.comboBoxThen.TabIndex = 1;
            this.comboBoxThen.Text = "Действие";
            this.comboBoxThen.SelectedIndexChanged += comboBoxThen_SelectedIndexChanged;
            this.comboBoxThen.Items.Add("Отправить команду");
            //
            // pictureBoxRemadeWhen
            //
            this.pictureBoxRemadeWhen.Location = new System.Drawing.Point(10, 40);
            this.pictureBoxRemadeWhen.Name = "pictureBoxRemadeWhen";
            this.pictureBoxRemadeWhen.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxRemadeWhen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxRemadeWhen.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\Remade.PNG");
            this.pictureBoxRemadeWhen.MouseClick += pictureBoxRemadeWhen_MouseClick;
            //
            // pictureBoxRemadeThen
            //
            this.pictureBoxRemadeThen.Location = new System.Drawing.Point(10, 100);
            this.pictureBoxRemadeThen.Name = "pictureBoxRemadeThen";
            this.pictureBoxRemadeThen.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxRemadeThen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxRemadeThen.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Image\\Remade.PNG");
            this.pictureBoxRemadeThen.MouseClick += pictureBoxRemadeThen_MouseClick;
            // 
            // ControlStateFSM
            // 
            this.Controls.Add(this.comboBoxThen);
            this.Controls.Add(this.comboBoxWhen);
            this.Controls.Add(this.pictureBoxRemadeWhen);
            this.Controls.Add(this.pictureBoxRemadeThen);*/
            this.buttonAddTrigger.Location = startBtTriggerSize;
            this.buttonAddTrigger.Name = "buttonAddTrigger";
            this.buttonAddTrigger.Size = btSize;
            this.buttonAddTrigger.TabIndex = 0;
            this.buttonAddTrigger.Text = "Добавить триггер";

            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
            deleteMenuItem.Click += deleteTriggerMenuItem_Click;
            this.buttonAddTrigger.ContextMenuStrip = new ContextMenuStrip();
            this.buttonAddTrigger.ContextMenuStrip.Items.Add(deleteMenuItem);
            this.firstState = isFirst;
            if (isFirst)
            {
                this.buttonAddTrigger.MouseClick += buttonAddTrigger_MouseClick;
                this.link = new List<ControlStateFSM>();
            }
            else
            {
                this.buttonAddTrigger.MouseClick += buttonAddIfTrigger_MouseClick;
                this.BorderStyle = BorderStyle.Fixed3D;
            }
            this.buttonAddTrigger.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.buttonAddTrigger.Width, this.buttonAddTrigger.Height, 20, 20));

            this.buttonAddAction.Location = startBtActionSize;
            this.buttonAddAction.Name = "buttonAddAction";
            this.buttonAddAction.Size = btSize;
            this.buttonAddAction.TabIndex = 0;
            this.buttonAddAction.Text = "Добавить действие";

            ToolStripMenuItem deleteActMenuItem = new ToolStripMenuItem("Удалить");
            deleteActMenuItem.Click += deleteActionMenuItem_Click;
            this.buttonAddAction.ContextMenuStrip = new ContextMenuStrip();
            this.buttonAddAction.ContextMenuStrip.Items.Add(deleteActMenuItem);

            this.buttonAddAction.MouseClick += buttonAddAction_MouseClick;
            this.buttonAddAction.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.buttonAddAction.Width, this.buttonAddAction.Height, 20, 20));


            this.Controls.Add(this.buttonAddTrigger);
            this.Controls.Add(this.buttonAddAction);
            this.BackColor = System.Drawing.SystemColors.Window;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Location = new System.Drawing.Point(e.X, e.Y);
            this.Name = "ControlStateFSM";
            this.Size = new System.Drawing.Size(200, 130);
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.ResumeLayout(false);

        }


        void deleteMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        void deleteTriggerMenuItem_Click(object sender, EventArgs e)
        {
            Control sourceControl = new Control();
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    sourceControl = owner.SourceControl;
                }
                else
                {
                    return;
                }
            }
            if(sourceControl.Text == "Добавить триггер")
            {
                return;
            }
            int tabIndex = sourceControl.TabIndex;
            sourceControl.Dispose();
            whenBlock.RemoveAt(tabIndex);
            foreach (var bt in this.Controls)
            {
                if (bt is Button && (bt as Button).TabIndex > tabIndex && 
                    ((bt as Button).Text == "Добавить триггер" || (bt as Button).Text == "Изменить триггер"))
                {
                    (bt as Button).TabIndex -= 1;
                    (bt as Button).Location = new System.Drawing.Point(startBtActionSize.X, (bt as Button).Location.Y - btSize.Height);
                }
                if(bt is Button && ((bt as Button).Text == "Добавить действие" || (bt as Button).Text == "Изменить действие"))
                {
                    (bt as Button).Location = new System.Drawing.Point(startBtActionSize.X, (bt as Button).Location.Y - btSize.Height);
                }
            }

            startBtActionSize.Y -= btSize.Height;
            endBtActionSize.Y -= btSize.Height;
            endBtTriggerSize.Y -= btSize.Height;

            this.Size = new System.Drawing.Size(200, this.Size.Height - btSize.Height);
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        void deleteActionMenuItem_Click(object sender, EventArgs e)
        {
            Control sourceControl = new Control();
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    sourceControl = owner.SourceControl;
                }
                else
                {
                    return;
                }
            }
            if (sourceControl.Text == "Добавить действие")
            {
                return;
            }
            int tabIndex = sourceControl.TabIndex;
            sourceControl.Dispose();
            thenBlock.RemoveAt(tabIndex);
            foreach (var bt in this.Controls)
            {
                if (bt is Button && (bt as Button).TabIndex > tabIndex &&
                    ((bt as Button).Text == "Добавить действие" || (bt as Button).Text == "Изменить действие"))
                {
                    (bt as Button).TabIndex -= 1;
                    (bt as Button).Location = new System.Drawing.Point(startBtActionSize.X, (bt as Button).Location.Y - btSize.Height);
                }
            }
            endBtActionSize.Y -= btSize.Height;
            this.Size = new System.Drawing.Size(200, this.Size.Height - btSize.Height);
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void buttonAddTrigger_MouseClick(object sender, MouseEventArgs e)
        {
            if((sender as Button).Text == "Изменить триггер")
            {
                if(whenBlock[(sender as Button).TabIndex] is TriggerItem)
                {
                    using (var win = new ItemEventForm(whenBlock[(sender as Button).TabIndex]))
                    {
                        var result = win.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            whenBlock[(sender as Button).TabIndex] = new TriggerItem(win.comboBoxItems.Text,
                                win.comboBoxFirst.Text, win.comboBoxSecond.Text, win.idTrigger);
                        }
                    }
                }
                else if(whenBlock[(sender as Button).TabIndex] is TriggerThing)
                {
                    using (var win = new ThingEventForm(whenBlock[(sender as Button).TabIndex]))
                    {
                        var result = win.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            whenBlock[(sender as Button).TabIndex] = new TriggerThing(win.comboBoxThings.Text,
                                win.comboBoxFirst.Text, win.comboBoxSecond.Text, win.idTrigger);
                        }
                    }
                }
                else if (whenBlock[(sender as Button).TabIndex] is TriggerTime)
                {
                    using (var win = new TimeEventForm(whenBlock[(sender as Button).TabIndex]))
                    {
                        var result = win.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            whenBlock[(sender as Button).TabIndex] = new TriggerTime(win.textBoxTime.Text, win.idTrigger);
                        }
                    }
                }
                else if (whenBlock[(sender as Button).TabIndex] is TriggerSystem)
                {
                    using (var win = new SystemEventForm(whenBlock[(sender as Button).TabIndex]))
                    {
                        var result = win.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            whenBlock[(sender as Button).TabIndex] = new TriggerSystem(win.idTrigger);
                        }
                    }
                }
                return;
            }
            using (var win = new AddTriggerForm())
            {
                var result = win.ShowDialog();
                if (result == DialogResult.OK)
                {
                    whenBlock.Add(win.trigger);
                    win.Close();

                    Button newBtAddTrigger = new Button();
                    startBtActionSize.Y += btSize.Height;
                    endBtActionSize.Y += btSize.Height;
                    newBtAddTrigger.Location = new System.Drawing.Point(endBtTriggerSize.X, endBtTriggerSize.Y + btSize.Height);
                    endBtTriggerSize.Y += btSize.Height;
                    newBtAddTrigger.Name = "buttonAddTrigger";
                    newBtAddTrigger.Size = btSize;
                    newBtAddTrigger.Text = "Добавить триггер";
                    newBtAddTrigger.TabIndex = (sender as Button).TabIndex + 1;
                    newBtAddTrigger.MouseClick += buttonAddTrigger_MouseClick;
                    newBtAddTrigger.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, newBtAddTrigger.Width, newBtAddTrigger.Height, 20, 20));

                    ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
                    deleteMenuItem.Click += deleteTriggerMenuItem_Click;
                    newBtAddTrigger.ContextMenuStrip = new ContextMenuStrip();
                    newBtAddTrigger.ContextMenuStrip.Items.Add(deleteMenuItem);
                    

                    (sender as Button).Text = "Изменить триггер";

                    foreach (var btAction in this.Controls)
                    {
                        /*if (btAction is Button && (btAction as Button).Name == "buttonAddTrigger")
                        {
                            (btAction as Button).Text = "Изменить триггер";
                        }*/
                        if (btAction is Button && (btAction as Button).Name == "buttonAddAction")
                        {
                            (btAction as Button).Location = new System.Drawing.Point(startBtActionSize.X, (btAction as Button).Location.Y + btSize.Height);
                        }
                    }

                    this.Size = new System.Drawing.Size(200, this.Size.Height + btSize.Height);
                    this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                    this.Controls.Add(newBtAddTrigger);
                }
            }
        }

        private void buttonAddAction_MouseClick(object sender, MouseEventArgs e)
        {
            if ((sender as Button).Text == "Изменить действие")
            {
                using (var win = new ItemActionForm(thenBlock[(sender as Button).TabIndex]))
                {
                    var result = win.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        thenBlock[(sender as Button).TabIndex] = new ActionItem(win.comboBoxItems.Text,
                            /*win.comboBoxCommand.Text,*/win.textBoxState.Text, win.idTrigger);
                    }
                }
                return;
            }
            using (var win = new ItemActionForm())
            {
                var result = win.ShowDialog();
                if (result == DialogResult.OK)
                {
                    thenBlock.Add(new ActionItem(win.comboBoxItems.Text, /*win.comboBoxCommand.Text,*/win.textBoxState.Text, win.idTrigger));
                    win.Close();

                    Button newBtAddAction = new Button();
                    newBtAddAction.Location = new System.Drawing.Point(endBtActionSize.X, endBtActionSize.Y + btSize.Height);
                    endBtActionSize.Y += btSize.Height;
                    newBtAddAction.Name = "buttonAddAction";
                    newBtAddAction.Size = btSize;
                    newBtAddAction.Text = "Добавить действие";
                    newBtAddAction.TabIndex = (sender as Button).TabIndex + 1;
                    newBtAddAction.MouseClick += buttonAddAction_MouseClick;
                    newBtAddAction.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, newBtAddAction.Width, newBtAddAction.Height, 20, 20));

                    ToolStripMenuItem deleteActMenuItem = new ToolStripMenuItem("Удалить");
                    deleteActMenuItem.Click += deleteActionMenuItem_Click;
                    newBtAddAction.ContextMenuStrip = new ContextMenuStrip();
                    newBtAddAction.ContextMenuStrip.Items.Add(deleteActMenuItem);

                    (sender as Button).Text = "Изменить действие";

                    this.Size = new System.Drawing.Size(200, this.Size.Height + btSize.Height);
                    this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                    this.Controls.Add(newBtAddAction);
                }
            }
        }

        private void buttonAddIfTrigger_MouseClick(object sender, MouseEventArgs e)
        {
            if ((sender as Button).Text == "Изменить триггер")
            {
                using (var win = new ItemIfForm(whenBlock[(sender as Button).TabIndex]))
                {
                    var result = win.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        whenBlock[(sender as Button).TabIndex] = new TriggerIf(win.comboBoxItems.Text,
                            win.textBoxState.Text, win.idTrigger);
                    }
                }
                return;
            }
            using (var win = new ItemIfForm())
            {
                var result = win.ShowDialog();
                if (result == DialogResult.OK)
                {
                    whenBlock.Add(new TriggerIf(win.comboBoxItems.Text, win.textBoxState.Text, win.idTrigger));
                    win.Close();

                    Button newBtAddTrigger = new Button();
                    startBtActionSize.Y += btSize.Height;
                    endBtActionSize.Y += btSize.Height;
                    newBtAddTrigger.Location = new System.Drawing.Point(endBtTriggerSize.X, endBtTriggerSize.Y + btSize.Height);
                    endBtTriggerSize.Y += btSize.Height;
                    newBtAddTrigger.Name = "buttonAddTrigger";
                    newBtAddTrigger.Size = btSize;
                    newBtAddTrigger.Text = "Добавить триггер";
                    newBtAddTrigger.TabIndex = (sender as Button).TabIndex + 1;
                    newBtAddTrigger.MouseClick += buttonAddIfTrigger_MouseClick;
                    newBtAddTrigger.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, newBtAddTrigger.Width, newBtAddTrigger.Height, 20, 20));

                    ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
                    deleteMenuItem.Click += deleteTriggerMenuItem_Click;
                    newBtAddTrigger.ContextMenuStrip = new ContextMenuStrip();
                    newBtAddTrigger.ContextMenuStrip.Items.Add(deleteMenuItem);

                    (sender as Button).Text = "Изменить триггер";

                    foreach (var btAction in this.Controls)
                    {
                        if (btAction is Button && (btAction as Button).Name == "buttonAddAction")
                        {
                            (btAction as Button).Location = new System.Drawing.Point(startBtActionSize.X, (btAction as Button).Location.Y + btSize.Height);
                        }
                    }

                    this.Size = new System.Drawing.Size(200, this.Size.Height + btSize.Height);
                    this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                    this.Controls.Add(newBtAddTrigger);
                }
            }

        }

        private void comboBoxWhen_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.comboBoxWhen.Text)
            {
                case "Устройство получило команду":
                    using(var win = new ItemReceivesCommandForm(Form.itemList))
                    {
                        var result = win.ShowDialog();
                        if(result == DialogResult.OK)
                        {
                            _deviceWhen = win.comboBoxItems.Text;
                            _stateWhen = win.comboBoxState.Text;
                        }
                    }
                    //ItemReceivesCommandForm winReceivesCom = new ItemReceivesCommandForm(Form.itemList);
                    //winReceivesCom.Show();
                    break;
                case "Устройство изменило состояние":
                    using (var win = new ItemStateChangesForm(Form.itemList))
                    {
                        var result = win.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            _deviceWhen = win.comboBoxItems.Text;
                            _stateWhen = win.comboBoxState.Text;
                            _prevState = win.comboBoxPrevState.Text;
                        }
                    }
                    //ItemStateChangesForm winStateChanges = new ItemStateChangesForm(Form.itemList);
                    //winStateChanges.Show();
                    break;
                case "Устройство обновило состояние":
                    using (var win = new ItemStateUpdatedForm(Form.itemList))
                    {
                        var result = win.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            _deviceWhen = win.comboBoxItems.Text;
                            _stateWhen = win.comboBoxState.Text;
                        }
                    }
                    //ItemStateUpdatedForm winStateUpdated = new ItemStateUpdatedForm(Form.itemList);
                    //winStateUpdated.Show();
                    break;
                case "Фиксированное время":
                    using (var win = new FixedTimeDayForm())
                    {
                        var result = win.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            //_device = win.comboBoxItems.Text;
                            _time = win.comboBoxHours.Text + ":" + win.comboBoxMinutes.Text; 
                        }
                    }
                    //FixedTimeDayForm winFixedTime = new FixedTimeDayForm();
                    //winFixedTime.Show();
                    break;
                case "Если состояние верно...":
                    break;
            }
        }

        private void comboBoxThen_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxThen.Text)
            {
                case "Отправить команду":
                    using (var win = new SendCommandForm(Form.itemList))
                    {
                        var result = win.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            _deviceThen = win.comboBoxItems.Text;
                            _stateThen = win.comboBoxState.Text;
                        }
                    }
                    //new SendCommandForm(Form.itemList).Show();
                    //winReceivesCom.Show();
                    break;
            }
        }

        private void pictureBoxRemadeWhen_MouseClick(object sender, MouseEventArgs e)
        {
            switch (this.comboBoxWhen.Text)
            {
                case "Устройство получило команду":
                    using (var win = new ItemReceivesCommandForm(Form.itemList, _deviceWhen, _stateWhen))
                    {
                        var result = win.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            _deviceWhen = win.comboBoxItems.Text;
                            _stateWhen = win.comboBoxState.Text;
                        }
                    }
                    break;
                case "Устройство изменило состояние":
                    using (var win = new ItemStateChangesForm(Form.itemList, _deviceWhen, _stateWhen, _prevState))
                    {
                        var result = win.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            _deviceWhen = win.comboBoxItems.Text;
                            _stateWhen = win.comboBoxState.Text;
                            _prevState = win.comboBoxPrevState.Text;
                        }
                    }
                    break;
                case "Устройство обновило состояние":
                    using (var win = new ItemStateUpdatedForm(Form.itemList, _deviceWhen, _stateWhen))
                    {
                        var result = win.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            _deviceWhen = win.comboBoxItems.Text;
                            _stateWhen = win.comboBoxState.Text;
                        }
                    }
                    break;
                case "Фиксированное время":
                    using (var win = new FixedTimeDayForm(_time))
                    {
                        var result = win.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            _time = win.comboBoxHours.Text + ":" + win.comboBoxMinutes.Text;
                        }
                    }
                    break;
                case "Если состояние верно...":
                    break;
            }
        }

        private void pictureBoxRemadeThen_MouseClick(object sender, MouseEventArgs e)
        {
            switch (this.comboBoxThen.Text)
            {
                case "Отправить команду":
                    using (var win = new SendCommandForm(Form.itemList, _deviceThen, _stateThen))
                    {
                        var result = win.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            _deviceThen = win.comboBoxItems.Text;
                            _stateThen = win.comboBoxState.Text;
                        }
                    }
                    break;
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            //this.BorderStyle = BorderStyle.Fixed3D;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Cursor = Cursors.Default;
            //this.BorderStyle = BorderStyle.None;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left && ((this.Location.X + e.X - _clickLocation.X >= 0) && (this.Location.Y + e.Y - _clickLocation.Y >= 40)))//перемещение
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - _clickLocation.X), this.Location.Y + (e.Y - _clickLocation.Y));
                

            }
            /*if (this.Location.X == 0)
            {
                this.Location = new System.Drawing.Point(0, this.Location.Y + (e.Y - _clickLocation.Y));
            }
            else if (this.Location.Y == 40)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - _clickLocation.X), 0);
            }*/
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _clickLocation = e.Location;
        }

        public IEnumerator GetEnumerator()
        {
            return link.GetEnumerator();
        }

        #endregion

        private ComboBox comboBoxWhen;
        private ComboBox comboBoxThen;
        private PictureBox pictureBoxRemadeWhen;
        private PictureBox pictureBoxRemadeThen;
        private Button buttonAddTrigger;
        private Button buttonAddAction;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
    }
}
