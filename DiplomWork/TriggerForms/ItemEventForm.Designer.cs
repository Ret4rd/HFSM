
namespace DiplomWork.TriggerForms
{
    partial class ItemEventForm
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
            this.labelTrigger = new System.Windows.Forms.Label();
            this.radioButtonReceivedCommand = new System.Windows.Forms.RadioButton();
            this.radioButtonStateUpdated = new System.Windows.Forms.RadioButton();
            this.radioButtonStateChanges = new System.Windows.Forms.RadioButton();
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.comboBoxFirst = new System.Windows.Forms.ComboBox();
            this.comboBoxSecond = new System.Windows.Forms.ComboBox();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTrigger
            // 
            this.labelTrigger.AutoSize = true;
            this.labelTrigger.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTrigger.Location = new System.Drawing.Point(93, 9);
            this.labelTrigger.Name = "labelTrigger";
            this.labelTrigger.Size = new System.Drawing.Size(125, 16);
            this.labelTrigger.TabIndex = 0;
            this.labelTrigger.Text = "Добавить триггер";
            // 
            // radioButtonReceivedCommand
            // 
            this.radioButtonReceivedCommand.AutoSize = true;
            this.radioButtonReceivedCommand.Checked = true;
            this.radioButtonReceivedCommand.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonReceivedCommand.Location = new System.Drawing.Point(28, 138);
            this.radioButtonReceivedCommand.Name = "radioButtonReceivedCommand";
            this.radioButtonReceivedCommand.Size = new System.Drawing.Size(151, 20);
            this.radioButtonReceivedCommand.TabIndex = 2;
            this.radioButtonReceivedCommand.TabStop = true;
            this.radioButtonReceivedCommand.Tag = "0";
            this.radioButtonReceivedCommand.Text = "Получена команда";
            this.radioButtonReceivedCommand.UseVisualStyleBackColor = true;
            this.radioButtonReceivedCommand.CheckedChanged += new System.EventHandler(this.radioButtonReceivedCommand_CheckedChanged);
            // 
            // radioButtonStateUpdated
            // 
            this.radioButtonStateUpdated.AutoSize = true;
            this.radioButtonStateUpdated.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonStateUpdated.Location = new System.Drawing.Point(28, 164);
            this.radioButtonStateUpdated.Name = "radioButtonStateUpdated";
            this.radioButtonStateUpdated.Size = new System.Drawing.Size(177, 20);
            this.radioButtonStateUpdated.TabIndex = 3;
            this.radioButtonStateUpdated.Tag = "1";
            this.radioButtonStateUpdated.Text = "Состояние обновилось";
            this.radioButtonStateUpdated.UseVisualStyleBackColor = true;
            this.radioButtonStateUpdated.CheckedChanged += new System.EventHandler(this.radioButtonStateUpdated_CheckedChanged);
            // 
            // radioButtonStateChanges
            // 
            this.radioButtonStateChanges.AutoSize = true;
            this.radioButtonStateChanges.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonStateChanges.Location = new System.Drawing.Point(28, 190);
            this.radioButtonStateChanges.Name = "radioButtonStateChanges";
            this.radioButtonStateChanges.Size = new System.Drawing.Size(178, 20);
            this.radioButtonStateChanges.TabIndex = 4;
            this.radioButtonStateChanges.Tag = "2";
            this.radioButtonStateChanges.Text = "Состояние изменилось";
            this.radioButtonStateChanges.UseVisualStyleBackColor = true;
            this.radioButtonStateChanges.CheckedChanged += new System.EventHandler(this.radioButtonStateChanges_CheckedChanged);
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFirst.Location = new System.Drawing.Point(12, 226);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(65, 16);
            this.labelFirst.TabIndex = 6;
            this.labelFirst.Text = "Команда";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSecond.Location = new System.Drawing.Point(12, 296);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(0, 16);
            this.labelSecond.TabIndex = 8;
            this.labelSecond.Visible = false;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(179, 354);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(109, 34);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "Готово";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // comboBoxFirst
            // 
            this.comboBoxFirst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFirst.FormattingEnabled = true;
            this.comboBoxFirst.Location = new System.Drawing.Point(12, 255);
            this.comboBoxFirst.Name = "comboBoxFirst";
            this.comboBoxFirst.Size = new System.Drawing.Size(276, 24);
            this.comboBoxFirst.TabIndex = 10;
            // 
            // comboBoxSecond
            // 
            this.comboBoxSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecond.FormattingEnabled = true;
            this.comboBoxSecond.Location = new System.Drawing.Point(12, 315);
            this.comboBoxSecond.Name = "comboBoxSecond";
            this.comboBoxSecond.Size = new System.Drawing.Size(276, 24);
            this.comboBoxSecond.TabIndex = 11;
            this.comboBoxSecond.Visible = false;
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(12, 70);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(276, 24);
            this.comboBoxItems.TabIndex = 12;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 354);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(109, 34);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ItemEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.comboBoxSecond);
            this.Controls.Add(this.comboBoxFirst);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.radioButtonStateChanges);
            this.Controls.Add(this.radioButtonStateUpdated);
            this.Controls.Add(this.radioButtonReceivedCommand);
            this.Controls.Add(this.labelTrigger);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label labelTrigger;
        protected System.Windows.Forms.RadioButton radioButtonReceivedCommand;
        protected System.Windows.Forms.RadioButton radioButtonStateUpdated;
        protected System.Windows.Forms.RadioButton radioButtonStateChanges;
        protected System.Windows.Forms.Label labelFirst;
        protected System.Windows.Forms.Label labelSecond;
        protected System.Windows.Forms.Button buttonOk;
        public System.Windows.Forms.ComboBox comboBoxFirst;
        public System.Windows.Forms.ComboBox comboBoxSecond;
        public System.Windows.Forms.ComboBox comboBoxItems;
        protected System.Windows.Forms.Button buttonBack;
    }
}