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
    public partial class SystemEventForm : System.Windows.Forms.Form
    {
        public ushort idTrigger;
        public SystemEventForm()
        {
            InitializeComponent();
        }

        public SystemEventForm(Trigger trigger) : this()
        {
            this.radioButtonSystem.Checked = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void radioButtonSystem_CheckedChanged(object sender, EventArgs e)
        {
            idTrigger = 0;
        }
    }
}
