
namespace DiplomWork.ActionForms
{
    partial class ItemActionForm
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
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.radioButtonStateUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonSendCommand = new System.Windows.Forms.RadioButton();
            this.labelAction = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.comboBoxCommand = new System.Windows.Forms.ComboBox();
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
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSecond.Location = new System.Drawing.Point(12, 298);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(0, 16);
            this.labelSecond.TabIndex = 19;
            this.labelSecond.Visible = false;
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFirst.Location = new System.Drawing.Point(12, 228);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(65, 16);
            this.labelFirst.TabIndex = 18;
            this.labelFirst.Text = "Команда";
            // 
            // radioButtonStateUpdate
            // 
            this.radioButtonStateUpdate.AutoSize = true;
            this.radioButtonStateUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonStateUpdate.Location = new System.Drawing.Point(28, 166);
            this.radioButtonStateUpdate.Name = "radioButtonStateUpdate";
            this.radioButtonStateUpdate.Size = new System.Drawing.Size(161, 20);
            this.radioButtonStateUpdate.TabIndex = 16;
            this.radioButtonStateUpdate.Tag = "1";
            this.radioButtonStateUpdate.Text = "Обновить состояние";
            this.radioButtonStateUpdate.UseVisualStyleBackColor = true;
            this.radioButtonStateUpdate.CheckedChanged += new System.EventHandler(this.radioButtonStateUpdate_CheckedChanged);
            // 
            // radioButtonSendCommand
            // 
            this.radioButtonSendCommand.AutoSize = true;
            this.radioButtonSendCommand.Checked = true;
            this.radioButtonSendCommand.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonSendCommand.Location = new System.Drawing.Point(28, 140);
            this.radioButtonSendCommand.Name = "radioButtonSendCommand";
            this.radioButtonSendCommand.Size = new System.Drawing.Size(156, 20);
            this.radioButtonSendCommand.TabIndex = 15;
            this.radioButtonSendCommand.TabStop = true;
            this.radioButtonSendCommand.Tag = "0";
            this.radioButtonSendCommand.Text = "Отправить команду";
            this.radioButtonSendCommand.UseVisualStyleBackColor = true;
            this.radioButtonSendCommand.CheckedChanged += new System.EventHandler(this.radioButtonSendCommand_CheckedChanged);
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAction.Location = new System.Drawing.Point(93, 11);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(136, 16);
            this.labelAction.TabIndex = 14;
            this.labelAction.Text = "Добавить действие";
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(12, 257);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(276, 22);
            this.textBoxState.TabIndex = 25;
            // 
            // comboBoxCommand
            // 
            this.comboBoxCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCommand.Enabled = false;
            this.comboBoxCommand.FormattingEnabled = true;
            this.comboBoxCommand.Location = new System.Drawing.Point(12, 290);
            this.comboBoxCommand.Name = "comboBoxCommand";
            this.comboBoxCommand.Size = new System.Drawing.Size(276, 24);
            this.comboBoxCommand.TabIndex = 21;
            this.comboBoxCommand.Visible = false;
            // 
            // ItemActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.comboBoxCommand);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.radioButtonStateUpdate);
            this.Controls.Add(this.radioButtonSendCommand);
            this.Controls.Add(this.labelAction);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemActionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemActionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button buttonBack;
        public System.Windows.Forms.ComboBox comboBoxItems;
        protected System.Windows.Forms.Button buttonOk;
        protected System.Windows.Forms.Label labelSecond;
        protected System.Windows.Forms.Label labelFirst;
        protected System.Windows.Forms.RadioButton radioButtonStateUpdate;
        protected System.Windows.Forms.RadioButton radioButtonSendCommand;
        protected System.Windows.Forms.Label labelAction;
        public System.Windows.Forms.TextBox textBoxState;
        public System.Windows.Forms.ComboBox comboBoxCommand;
    }
}