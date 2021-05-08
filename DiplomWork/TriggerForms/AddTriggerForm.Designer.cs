
namespace DiplomWork.TriggerForms
{
    partial class AddTriggerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTriggerForm));
            this.labelWhen = new System.Windows.Forms.Label();
            this.buttonItemEvent = new System.Windows.Forms.Button();
            this.buttonThingEvent = new System.Windows.Forms.Button();
            this.buttonTimeEvent = new System.Windows.Forms.Button();
            this.buttonSystemEvent = new System.Windows.Forms.Button();
            this.pictureBoxCancel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWhen
            // 
            this.labelWhen.AutoSize = true;
            this.labelWhen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhen.Location = new System.Drawing.Point(119, 9);
            this.labelWhen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWhen.Name = "labelWhen";
            this.labelWhen.Size = new System.Drawing.Size(60, 20);
            this.labelWhen.TabIndex = 0;
            this.labelWhen.Text = "Когда";
            this.labelWhen.Click += new System.EventHandler(this.labelWhen_Click);
            // 
            // buttonItemEvent
            // 
            this.buttonItemEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonItemEvent.BackgroundImage")));
            this.buttonItemEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonItemEvent.Location = new System.Drawing.Point(17, 42);
            this.buttonItemEvent.Name = "buttonItemEvent";
            this.buttonItemEvent.Size = new System.Drawing.Size(122, 119);
            this.buttonItemEvent.TabIndex = 1;
            this.buttonItemEvent.UseVisualStyleBackColor = true;
            this.buttonItemEvent.Click += new System.EventHandler(this.buttonItemEvent_Click);
            // 
            // buttonThingEvent
            // 
            this.buttonThingEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonThingEvent.BackgroundImage")));
            this.buttonThingEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonThingEvent.Location = new System.Drawing.Point(166, 42);
            this.buttonThingEvent.Name = "buttonThingEvent";
            this.buttonThingEvent.Size = new System.Drawing.Size(122, 119);
            this.buttonThingEvent.TabIndex = 2;
            this.buttonThingEvent.UseVisualStyleBackColor = true;
            this.buttonThingEvent.Click += new System.EventHandler(this.buttonThingEvent_Click);
            // 
            // buttonTimeEvent
            // 
            this.buttonTimeEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTimeEvent.BackgroundImage")));
            this.buttonTimeEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTimeEvent.Location = new System.Drawing.Point(17, 167);
            this.buttonTimeEvent.Name = "buttonTimeEvent";
            this.buttonTimeEvent.Size = new System.Drawing.Size(122, 119);
            this.buttonTimeEvent.TabIndex = 3;
            this.buttonTimeEvent.UseVisualStyleBackColor = true;
            this.buttonTimeEvent.Click += new System.EventHandler(this.buttonTimeEvent_Click);
            // 
            // buttonSystemEvent
            // 
            this.buttonSystemEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSystemEvent.BackgroundImage")));
            this.buttonSystemEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSystemEvent.Location = new System.Drawing.Point(166, 167);
            this.buttonSystemEvent.Name = "buttonSystemEvent";
            this.buttonSystemEvent.Size = new System.Drawing.Size(122, 119);
            this.buttonSystemEvent.TabIndex = 4;
            this.buttonSystemEvent.UseVisualStyleBackColor = true;
            this.buttonSystemEvent.Click += new System.EventHandler(this.buttonSystemEvent_Click);
            // 
            // pictureBoxCancel
            // 
            this.pictureBoxCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCancel.BackgroundImage")));
            this.pictureBoxCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCancel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCancel.Image")));
            this.pictureBoxCancel.InitialImage = null;
            this.pictureBoxCancel.Location = new System.Drawing.Point(17, 9);
            this.pictureBoxCancel.Name = "pictureBoxCancel";
            this.pictureBoxCancel.Size = new System.Drawing.Size(31, 27);
            this.pictureBoxCancel.TabIndex = 5;
            this.pictureBoxCancel.TabStop = false;
            this.pictureBoxCancel.Click += new System.EventHandler(this.pictureBoxCancel_Click);
            this.pictureBoxCancel.MouseEnter += new System.EventHandler(this.pictureBoxCancel_MouseEnter);
            this.pictureBoxCancel.MouseLeave += new System.EventHandler(this.pictureBoxCancel_MouseLeave);
            // 
            // AddTriggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.pictureBoxCancel);
            this.Controls.Add(this.buttonSystemEvent);
            this.Controls.Add(this.buttonTimeEvent);
            this.Controls.Add(this.buttonThingEvent);
            this.Controls.Add(this.buttonItemEvent);
            this.Controls.Add(this.labelWhen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTriggerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить триггер";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWhen;
        private System.Windows.Forms.Button buttonItemEvent;
        private System.Windows.Forms.Button buttonThingEvent;
        private System.Windows.Forms.Button buttonTimeEvent;
        private System.Windows.Forms.Button buttonSystemEvent;
        private System.Windows.Forms.PictureBox pictureBoxCancel;
    }
}