
namespace DiplomWork.TriggerForms
{
    partial class ItemStateUpdatedForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelNameTrig = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelConfigurations = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.labelCommand = new System.Windows.Forms.Label();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(127, 367);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(137, 39);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(283, 367);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(137, 39);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(38, 69);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(34, 16);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя";
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.Location = new System.Drawing.Point(122, 9);
            this.labelMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(188, 25);
            this.labelMain.TabIndex = 3;
            this.labelMain.Text = "Добавить триггер";
            // 
            // labelNameTrig
            // 
            this.labelNameTrig.AutoSize = true;
            this.labelNameTrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameTrig.Location = new System.Drawing.Point(38, 101);
            this.labelNameTrig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameTrig.Name = "labelNameTrig";
            this.labelNameTrig.Size = new System.Drawing.Size(226, 16);
            this.labelNameTrig.TabIndex = 4;
            this.labelNameTrig.Text = "Состояние элемента обновилось";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription.Location = new System.Drawing.Point(38, 149);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(73, 16);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Описание";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDesc.Location = new System.Drawing.Point(38, 182);
            this.labelDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(301, 32);
            this.labelDesc.TabIndex = 6;
            this.labelDesc.Text = "Запускает скрипт, если состояние элемента\r\n обновляется (даже если оно не изменяе" +
    "тся)";
            // 
            // labelConfigurations
            // 
            this.labelConfigurations.AutoSize = true;
            this.labelConfigurations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConfigurations.Location = new System.Drawing.Point(37, 217);
            this.labelConfigurations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConfigurations.Name = "labelConfigurations";
            this.labelConfigurations.Size = new System.Drawing.Size(141, 24);
            this.labelConfigurations.TabIndex = 7;
            this.labelConfigurations.Text = "Конфигурации";
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelItem.Location = new System.Drawing.Point(38, 252);
            this.labelItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(85, 16);
            this.labelItem.TabIndex = 8;
            this.labelItem.Text = "Устройство";
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCommand.Location = new System.Drawing.Point(256, 252);
            this.labelCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(78, 16);
            this.labelCommand.TabIndex = 9;
            this.labelCommand.Text = "Состояние";
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(41, 290);
            this.comboBoxItems.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(167, 24);
            this.comboBoxItems.TabIndex = 10;
            // 
            // comboBoxState
            // 
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Location = new System.Drawing.Point(258, 290);
            this.comboBoxState.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(160, 24);
            this.comboBoxState.TabIndex = 11;
            // 
            // ItemStateUpdatedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(431, 419);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.labelCommand);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.labelConfigurations);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelNameTrig);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemStateUpdatedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить триггер";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelNameTrig;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelConfigurations;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label labelCommand;
        public System.Windows.Forms.ComboBox comboBoxItems;
        public System.Windows.Forms.ComboBox comboBoxState;
    }
}