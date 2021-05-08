namespace DiplomWork
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.labelItem = new System.Windows.Forms.Label();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.pictureBoxAuto = new System.Windows.Forms.PictureBox();
            this.pictureBoxHierarchicalAuto = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHierarchicalAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Cyan;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(659, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.CreateToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.CreateToolStripMenuItem.Text = "Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(17, 75);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(149, 24);
            this.comboBoxItem.TabIndex = 1;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonColor);
            this.groupBox.Controls.Add(this.labelItem);
            this.groupBox.Controls.Add(this.pictureBoxArrow);
            this.groupBox.Controls.Add(this.pictureBoxAuto);
            this.groupBox.Controls.Add(this.pictureBoxHierarchicalAuto);
            this.groupBox.Controls.Add(this.comboBoxItem);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.Location = new System.Drawing.Point(478, 24);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(181, 360);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Элементы управления";
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(42, 300);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 6;
            this.buttonColor.Text = "Цвет";
            this.buttonColor.UseVisualStyleBackColor = true;
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(14, 45);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(152, 16);
            this.labelItem.TabIndex = 5;
            this.labelItem.Text = "Выберите устройство";
            this.labelItem.Click += new System.EventHandler(this.labelItem_Click);
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBoxArrow.Location = new System.Drawing.Point(66, 223);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(51, 45);
            this.pictureBoxArrow.TabIndex = 4;
            this.pictureBoxArrow.TabStop = false;
            this.pictureBoxArrow.Click += new System.EventHandler(this.pictureBoxArrow_Click);
            // 
            // pictureBoxAuto
            // 
            this.pictureBoxAuto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxAuto.Location = new System.Drawing.Point(118, 158);
            this.pictureBoxAuto.Name = "pictureBoxAuto";
            this.pictureBoxAuto.Size = new System.Drawing.Size(51, 45);
            this.pictureBoxAuto.TabIndex = 3;
            this.pictureBoxAuto.TabStop = false;
            this.pictureBoxAuto.Click += new System.EventHandler(this.pictureBoxAuto_Click);
            // 
            // pictureBoxHierarchicalAuto
            // 
            this.pictureBoxHierarchicalAuto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxHierarchicalAuto.Location = new System.Drawing.Point(17, 158);
            this.pictureBoxHierarchicalAuto.Name = "pictureBoxHierarchicalAuto";
            this.pictureBoxHierarchicalAuto.Size = new System.Drawing.Size(51, 45);
            this.pictureBoxHierarchicalAuto.TabIndex = 2;
            this.pictureBoxHierarchicalAuto.TabStop = false;
            this.pictureBoxHierarchicalAuto.Click += new System.EventHandler(this.pictureBoxHierarchicalAuto_Click);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(478, 360);
            this.tabControl.TabIndex = 3;
            this.tabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(659, 384);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form";
            this.Text = "DiplomWork";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_KeyPress);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHierarchicalAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.GroupBox groupBox;
        public System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
        private System.Windows.Forms.PictureBox pictureBoxAuto;
        private System.Windows.Forms.PictureBox pictureBoxHierarchicalAuto;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

