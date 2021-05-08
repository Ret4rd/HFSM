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
    public partial class ThingEventForm : System.Windows.Forms.Form
    {
        protected List<string> _thingList;
        protected List<string> _stateList = new List<string> { "UNINITIALIZED", "INITIALIZING", "UNKNOWN", "ONLINE", "OFFLINE", "REMOVING", "REMOVED" };

        public ushort idTrigger;
        public ThingEventForm()
        {
            InitializeComponent();
            for (int i = 0; i < _stateList.Count; i++)
            {
                this.comboBoxFirst.Items.Add(_stateList[i]);
                this.comboBoxSecond.Items.Add(_stateList[i]);
            }
        }

        public ThingEventForm(Trigger trigger) : this()
        {
            this.comboBoxThings.Text = trigger.device;
            this.comboBoxFirst.Text = trigger.state;
            this.comboBoxSecond.Text = trigger.prevState;
            switch (trigger.idTrigger)
            {
                case 0:
                    this.radioButtonStateUpdated.Checked = true;
                    break;
                case 1:
                    this.radioButtonStateChanges.Checked = true;
                    break;
            }
        }

        private void labelTrigger_Click(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (this.comboBoxThings.Text == "")
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

        private void radioButtonStateUpdated_CheckedChanged(object sender, EventArgs e)
        {
            this.labelFirst.Text = "В состояние";
            this.idTrigger = 0;
        }

        private void radioButtonStateChanges_CheckedChanged(object sender, EventArgs e)
        {
            this.labelFirst.Text = "В состояние";
            this.labelSecond.Text = "Из состояния";
            this.labelSecond.Visible = true;
            this.comboBoxSecond.Visible = true;
            this.idTrigger = 1;
        }
    }
}
