
namespace DiplomWork.TriggerForms
{
    partial class TimeEventForm
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelFirst = new System.Windows.Forms.Label();
            this.radioButtonFixedTime = new System.Windows.Forms.RadioButton();
            this.radioButtonCron = new System.Windows.Forms.RadioButton();
            this.labelTrigger = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
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
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFirst.Location = new System.Drawing.Point(12, 228);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(49, 16);
            this.labelFirst.TabIndex = 18;
            this.labelFirst.Text = "Время";
            // 
            // radioButtonFixedTime
            // 
            this.radioButtonFixedTime.AutoSize = true;
            this.radioButtonFixedTime.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonFixedTime.Location = new System.Drawing.Point(28, 166);
            this.radioButtonFixedTime.Name = "radioButtonFixedTime";
            this.radioButtonFixedTime.Size = new System.Drawing.Size(186, 20);
            this.radioButtonFixedTime.TabIndex = 16;
            this.radioButtonFixedTime.Text = "В фиксированное время";
            this.radioButtonFixedTime.UseVisualStyleBackColor = true;
            this.radioButtonFixedTime.CheckedChanged += new System.EventHandler(this.radioButtonFixedTime_CheckedChanged);
            // 
            // radioButtonCron
            // 
            this.radioButtonCron.AutoSize = true;
            this.radioButtonCron.Checked = true;
            this.radioButtonCron.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonCron.Location = new System.Drawing.Point(28, 140);
            this.radioButtonCron.Name = "radioButtonCron";
            this.radioButtonCron.Size = new System.Drawing.Size(127, 20);
            this.radioButtonCron.TabIndex = 15;
            this.radioButtonCron.TabStop = true;
            this.radioButtonCron.Text = "По расписанию";
            this.radioButtonCron.UseVisualStyleBackColor = true;
            this.radioButtonCron.CheckedChanged += new System.EventHandler(this.radioButtonCron_CheckedChanged);
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
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(12, 256);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(276, 22);
            this.textBoxTime.TabIndex = 25;
            // 
            // TimeEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.radioButtonFixedTime);
            this.Controls.Add(this.radioButtonCron);
            this.Controls.Add(this.labelTrigger);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimeEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeEventForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button buttonBack;
        protected System.Windows.Forms.Button buttonOk;
        protected System.Windows.Forms.Label labelFirst;
        protected System.Windows.Forms.RadioButton radioButtonFixedTime;
        protected System.Windows.Forms.RadioButton radioButtonCron;
        protected System.Windows.Forms.Label labelTrigger;
        public System.Windows.Forms.TextBox textBoxTime;
    }
}