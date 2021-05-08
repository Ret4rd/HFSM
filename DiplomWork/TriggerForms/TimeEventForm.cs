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
    public partial class TimeEventForm : System.Windows.Forms.Form
    {
        public ushort idTrigger;

        public TimeEventForm()
        {
            InitializeComponent();
        }

        public TimeEventForm(Trigger trigger) : this()
        {
            this.textBoxTime.Text = trigger.time;
            switch (trigger.idTrigger)
            {
                case 0:
                    this.radioButtonCron.Checked = true;
                    break;
                case 1:
                    this.radioButtonFixedTime.Checked = true;
                    break;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (this.textBoxTime.Text == "")
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

        private void radioButtonFixedTime_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxTime.Text = "00:00";
            this.idTrigger = 1;
        }

        private void radioButtonCron_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxTime.Text = "";
            this.idTrigger = 0;
        }
    }
}
