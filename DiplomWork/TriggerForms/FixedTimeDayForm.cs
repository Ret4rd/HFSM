using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomWork.TriggerForms
{
    public partial class FixedTimeDayForm : System.Windows.Forms.Form
    {
        public FixedTimeDayForm()
        {
            InitializeComponent();
            for(int hour = 0; hour < 24; hour++)
            {
                this.comboBoxHours.Items.Add(hour);
            }
            for(int minute = 0; minute < 60; minute++)
            {
                this.comboBoxMinutes.Items.Add(minute);
            }
        }

        public FixedTimeDayForm(string time)
        {
            InitializeComponent();
            for (int hour = 0; hour < 24; hour++)
            {
                this.comboBoxHours.Items.Add(hour);
            }
            for (int minute = 0; minute < 60; minute++)
            {
                this.comboBoxMinutes.Items.Add(minute);
            }
            this.comboBoxHours.Text = time.Split(':')[0];
            this.comboBoxMinutes.Text = time.Split(':')[1];
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
