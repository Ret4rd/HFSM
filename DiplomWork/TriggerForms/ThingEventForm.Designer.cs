
namespace DiplomWork.TriggerForms
{
    partial class ThingEventForm
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
            this.comboBoxThings = new System.Windows.Forms.ComboBox();
            this.comboBoxSecond = new System.Windows.Forms.ComboBox();
            this.comboBoxFirst = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.radioButtonStateChanges = new System.Windows.Forms.RadioButton();
            this.radioButtonStateUpdated = new System.Windows.Forms.RadioButton();
            this.labelTrigger = new System.Windows.Forms.Label();
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
            // comboBoxThings
            // 
            this.comboBoxThings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThings.FormattingEnabled = true;
            this.comboBoxThings.Location = new System.Drawing.Point(12, 72);
            this.comboBoxThings.Name = "comboBoxThings";
            this.comboBoxThings.Size = new System.Drawing.Size(276, 24);
            this.comboBoxThings.TabIndex = 23;
            // 
            // comboBoxSecond
            // 
            this.comboBoxSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecond.FormattingEnabled = true;
            this.comboBoxSecond.Location = new System.Drawing.Point(12, 317);
            this.comboBoxSecond.Name = "comboBoxSecond";
            this.comboBoxSecond.Size = new System.Drawing.Size(276, 24);
            this.comboBoxSecond.TabIndex = 22;
            this.comboBoxSecond.Visible = false;
            // 
            // comboBoxFirst
            // 
            this.comboBoxFirst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFirst.FormattingEnabled = true;
            this.comboBoxFirst.Location = new System.Drawing.Point(12, 257);
            this.comboBoxFirst.Name = "comboBoxFirst";
            this.comboBoxFirst.Size = new System.Drawing.Size(276, 24);
            this.comboBoxFirst.TabIndex = 21;
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
            this.labelFirst.Size = new System.Drawing.Size(88, 16);
            this.labelFirst.TabIndex = 18;
            this.labelFirst.Text = "В состояние";
            // 
            // radioButtonStateChanges
            // 
            this.radioButtonStateChanges.AutoSize = true;
            this.radioButtonStateChanges.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonStateChanges.Location = new System.Drawing.Point(28, 192);
            this.radioButtonStateChanges.Name = "radioButtonStateChanges";
            this.radioButtonStateChanges.Size = new System.Drawing.Size(178, 20);
            this.radioButtonStateChanges.TabIndex = 17;
            this.radioButtonStateChanges.Text = "Состояние изменилось";
            this.radioButtonStateChanges.UseVisualStyleBackColor = true;
            this.radioButtonStateChanges.CheckedChanged += new System.EventHandler(this.radioButtonStateChanges_CheckedChanged);
            // 
            // radioButtonStateUpdated
            // 
            this.radioButtonStateUpdated.AutoSize = true;
            this.radioButtonStateUpdated.Checked = true;
            this.radioButtonStateUpdated.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonStateUpdated.Location = new System.Drawing.Point(28, 166);
            this.radioButtonStateUpdated.Name = "radioButtonStateUpdated";
            this.radioButtonStateUpdated.Size = new System.Drawing.Size(177, 20);
            this.radioButtonStateUpdated.TabIndex = 16;
            this.radioButtonStateUpdated.TabStop = true;
            this.radioButtonStateUpdated.Text = "Состояние обновилось";
            this.radioButtonStateUpdated.UseVisualStyleBackColor = true;
            this.radioButtonStateUpdated.CheckedChanged += new System.EventHandler(this.radioButtonStateUpdated_CheckedChanged);
            // 
            // labelTrigger
            // 
            this.labelTrigger.AutoSize = true;
            this.labelTrigger.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTrigger.Location = new System.Drawing.Point(93, 11);
            this.labelTrigger.Name = "labelTrigger";
            this.labelTrigger.Size = new System.Drawing.Size(125, 16);
            this.labelTrigger.TabIndex = 14;
            this.labelTrigger.Text = "Добавить триггер";
            // 
            // ThingEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxThings);
            this.Controls.Add(this.comboBoxSecond);
            this.Controls.Add(this.comboBoxFirst);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.radioButtonStateChanges);
            this.Controls.Add(this.radioButtonStateUpdated);
            this.Controls.Add(this.labelTrigger);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThingEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThingEventForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button buttonBack;
        public System.Windows.Forms.ComboBox comboBoxThings;
        public System.Windows.Forms.ComboBox comboBoxSecond;
        public System.Windows.Forms.ComboBox comboBoxFirst;
        protected System.Windows.Forms.Button buttonOk;
        protected System.Windows.Forms.Label labelSecond;
        protected System.Windows.Forms.Label labelFirst;
        protected System.Windows.Forms.RadioButton radioButtonStateChanges;
        protected System.Windows.Forms.RadioButton radioButtonStateUpdated;
        protected System.Windows.Forms.Label labelTrigger;
    }
}