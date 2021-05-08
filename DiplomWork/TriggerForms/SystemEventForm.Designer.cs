
namespace DiplomWork.TriggerForms
{
    partial class SystemEventForm
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
            this.radioButtonSystem = new System.Windows.Forms.RadioButton();
            this.labelTrigger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 356);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(109, 34);
            this.buttonBack.TabIndex = 33;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(179, 356);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(109, 34);
            this.buttonOk.TabIndex = 29;
            this.buttonOk.Text = "Готово";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // radioButtonSystem
            // 
            this.radioButtonSystem.AutoSize = true;
            this.radioButtonSystem.Checked = true;
            this.radioButtonSystem.ForeColor = System.Drawing.SystemColors.Control;
            this.radioButtonSystem.Location = new System.Drawing.Point(58, 131);
            this.radioButtonSystem.Name = "radioButtonSystem";
            this.radioButtonSystem.Size = new System.Drawing.Size(183, 20);
            this.radioButtonSystem.TabIndex = 26;
            this.radioButtonSystem.TabStop = true;
            this.radioButtonSystem.Text = "Система начала работу";
            this.radioButtonSystem.UseVisualStyleBackColor = true;
            this.radioButtonSystem.CheckedChanged += new System.EventHandler(this.radioButtonSystem_CheckedChanged);
            // 
            // labelTrigger
            // 
            this.labelTrigger.AutoSize = true;
            this.labelTrigger.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTrigger.Location = new System.Drawing.Point(93, 11);
            this.labelTrigger.Name = "labelTrigger";
            this.labelTrigger.Size = new System.Drawing.Size(125, 16);
            this.labelTrigger.TabIndex = 25;
            this.labelTrigger.Text = "Добавить триггер";
            // 
            // SystemEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.radioButtonSystem);
            this.Controls.Add(this.labelTrigger);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SystemEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemEventForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button buttonBack;
        protected System.Windows.Forms.Button buttonOk;
        protected System.Windows.Forms.RadioButton radioButtonSystem;
        protected System.Windows.Forms.Label labelTrigger;
    }
}