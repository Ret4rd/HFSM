using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiplomWork.Triggers;

namespace DiplomWork.TriggerForms
{
    public partial class ItemEventForm : System.Windows.Forms.Form
    {
        
        protected List<string> _itemList;
        protected List<string> _stateList = new List<string> { "CLOSED", "OPEN", "DOWN", "UP", "OFF", "ON" };

        public ushort idTrigger;
        public ItemEventForm()
        {
            _itemList = Form.itemList;
            InitializeComponent();
            for (int i = 0; i < _itemList.Count; i++)
            {
                this.comboBoxItems.Items.Add(_itemList[i]);
            }

            for (int i = 0; i < _stateList.Count; i++)
            {
                this.comboBoxFirst.Items.Add(_stateList[i]);
                this.comboBoxSecond.Items.Add(_stateList[i]);
            }

        }

        public ItemEventForm(Trigger trigger):this()
        {
            this.comboBoxItems.Text = trigger.device;
            this.comboBoxFirst.Text = trigger.state;
            this.comboBoxSecond.Text = trigger.prevState;
            switch(trigger.idTrigger)
            {
                case 0: this.radioButtonReceivedCommand.Checked = true;
                    break;
                case 1:
                    this.radioButtonStateUpdated.Checked = true;
                    break;
                case 2:
                    this.radioButtonStateChanges.Checked = true;
                    break;
            }
        }

        private void radioButtonReceivedCommand_CheckedChanged(object sender, EventArgs e)
        {
            this.labelFirst.Text = "Команда";
            this.labelSecond.Visible = false;
            this.comboBoxSecond.Visible = false;
            this.idTrigger = 0;
        }

        private void radioButtonStateUpdated_CheckedChanged(object sender, EventArgs e)
        {
            this.labelFirst.Text = "В состояние";
            this.labelSecond.Visible = false;
            this.comboBoxSecond.Visible = false;
            this.idTrigger = 1;
        }

        private void radioButtonStateChanges_CheckedChanged(object sender, EventArgs e)
        {
            this.labelFirst.Text = "В состояние";
            this.labelSecond.Text = "Из состояния";
            this.labelSecond.Visible = true;
            this.comboBoxSecond.Visible = true;
            this.idTrigger = 2;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(this.comboBoxItems.Text == "")
            {
                return;
            }    
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
