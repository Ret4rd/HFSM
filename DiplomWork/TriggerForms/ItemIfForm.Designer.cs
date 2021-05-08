
namespace DiplomWork.TriggerForms
{
    partial class ItemIfForm
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelState = new System.Windows.Forms.Label();
            this.radioButtonGreaterEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonGrater = new System.Windows.Forms.RadioButton();
            this.radioButtonNotEqual = new System.Windows.Forms.RadioButton();
            this.labelTrigger = new System.Windows.Forms.Label();
            this.radioButtonEqual = new System.Windows.Forms.RadioButton();
            this.radioButtonLess = new System.Windows.Forms.RadioButton();
            this.radioButtonLessEqual = new System.Windows.Forms.RadioButton();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 356);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(109, 34);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(12, 72);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(276, 24);
            this.comboBoxItems.TabIndex = 23;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(179, 356);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(109, 34);
            this.buttonOk.TabIndex = 20;
            this.buttonOk.Text = "Готово";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.ForeColor = System.Drawing.SystemColors.Control;
            this.labelState.Location = new System.Drawing.Point(12, 273);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(78, 16);
            this.labelState.TabIndex = 18;
            this.labelState.Text = "Состояние";
            // 
            // radioButtonGreaterEqual
            // 
            this.radioButtonGreaterEqual.AutoSize = true;
            this.radioButtonGreaterEqual.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonGreaterEqual.Location = new System.Drawing.Point(28, 192);
            this.radioButtonGreaterEqual.Name = "radioButtonGreaterEqual";
            this.radioButtonGreaterEqual.Size = new System.Drawing.Size(145, 20);
            this.radioButtonGreaterEqual.TabIndex = 17;
            this.radioButtonGreaterEqual.Tag = "2";
            this.radioButtonGreaterEqual.Text = "Больше или равно";
            this.radioButtonGreaterEqual.UseVisualStyleBackColor = true;
            // 
            // radioButtonGrater
            // 
            this.radioButtonGrater.AutoSize = true;
            this.radioButtonGrater.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonGrater.Location = new System.Drawing.Point(28, 166);
            this.radioButtonGrater.Name = "radioButtonGrater";
            this.radioButtonGrater.Size = new System.Drawing.Size(103, 20);
            this.radioButtonGrater.TabIndex = 16;
            this.radioButtonGrater.Tag = "1";
            this.radioButtonGrater.Text = "Больше чем";
            this.radioButtonGrater.UseVisualStyleBackColor = true;
            // 
            // radioButtonNotEqual
            // 
            this.radioButtonNotEqual.AutoSize = true;
            this.radioButtonNotEqual.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonNotEqual.Location = new System.Drawing.Point(28, 140);
            this.radioButtonNotEqual.Name = "radioButtonNotEqual";
            this.radioButtonNotEqual.Size = new System.Drawing.Size(141, 20);
            this.radioButtonNotEqual.TabIndex = 15;
            this.radioButtonNotEqual.Tag = "0";
            this.radioButtonNotEqual.Text = "Не эквивалентно";
            this.radioButtonNotEqual.UseVisualStyleBackColor = true;
            // 
            // labelTrigger
            // 
            this.labelTrigger.AutoSize = true;
            this.labelTrigger.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTrigger.Location = new System.Drawing.Point(93, 11);
            this.labelTrigger.Name = "labelTrigger";
            this.labelTrigger.Size = new System.Drawing.Size(129, 16);
            this.labelTrigger.TabIndex = 14;
            this.labelTrigger.Text = "Добавить условие";
            // 
            // radioButtonEqual
            // 
            this.radioButtonEqual.AutoSize = true;
            this.radioButtonEqual.Checked = true;
            this.radioButtonEqual.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonEqual.Location = new System.Drawing.Point(28, 114);
            this.radioButtonEqual.Name = "radioButtonEqual";
            this.radioButtonEqual.Size = new System.Drawing.Size(122, 20);
            this.radioButtonEqual.TabIndex = 25;
            this.radioButtonEqual.TabStop = true;
            this.radioButtonEqual.Tag = "0";
            this.radioButtonEqual.Text = "Эквивалентно";
            this.radioButtonEqual.UseVisualStyleBackColor = true;
            this.radioButtonEqual.CheckedChanged += new System.EventHandler(this.radioButtonEqual_CheckedChanged);
            // 
            // radioButtonLess
            // 
            this.radioButtonLess.AutoSize = true;
            this.radioButtonLess.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonLess.Location = new System.Drawing.Point(28, 218);
            this.radioButtonLess.Name = "radioButtonLess";
            this.radioButtonLess.Size = new System.Drawing.Size(77, 20);
            this.radioButtonLess.TabIndex = 26;
            this.radioButtonLess.Tag = "2";
            this.radioButtonLess.Text = "Меньше";
            this.radioButtonLess.UseVisualStyleBackColor = true;
            // 
            // radioButtonLessEqual
            // 
            this.radioButtonLessEqual.AutoSize = true;
            this.radioButtonLessEqual.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonLessEqual.Location = new System.Drawing.Point(28, 244);
            this.radioButtonLessEqual.Name = "radioButtonLessEqual";
            this.radioButtonLessEqual.Size = new System.Drawing.Size(147, 20);
            this.radioButtonLessEqual.TabIndex = 27;
            this.radioButtonLessEqual.Tag = "2";
            this.radioButtonLessEqual.Text = "Меньше или равно";
            this.radioButtonLessEqual.UseVisualStyleBackColor = true;
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(12, 292);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(276, 22);
            this.textBoxState.TabIndex = 28;
            // 
            // ItemIfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.radioButtonLessEqual);
            this.Controls.Add(this.radioButtonLess);
            this.Controls.Add(this.radioButtonEqual);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.radioButtonGreaterEqual);
            this.Controls.Add(this.radioButtonGrater);
            this.Controls.Add(this.radioButtonNotEqual);
            this.Controls.Add(this.labelTrigger);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ItemIfForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemIfForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button buttonBack;
        public System.Windows.Forms.ComboBox comboBoxItems;
        protected System.Windows.Forms.Button buttonOk;
        protected System.Windows.Forms.Label labelState;
        protected System.Windows.Forms.RadioButton radioButtonGreaterEqual;
        protected System.Windows.Forms.RadioButton radioButtonGrater;
        protected System.Windows.Forms.RadioButton radioButtonNotEqual;
        protected System.Windows.Forms.Label labelTrigger;
        protected System.Windows.Forms.RadioButton radioButtonEqual;
        protected System.Windows.Forms.RadioButton radioButtonLess;
        protected System.Windows.Forms.RadioButton radioButtonLessEqual;
        public System.Windows.Forms.TextBox textBoxState;
    }
}