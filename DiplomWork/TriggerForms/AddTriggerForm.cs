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
    public partial class AddTriggerForm : System.Windows.Forms.Form
    {

        public Trigger trigger;
        public AddTriggerForm()
        {
            InitializeComponent();
        }

        private void labelWhen_Click(object sender, EventArgs e)
        {

        }

        private void buttonItemEvent_Click(object sender, EventArgs e)
        {
            using(var win = new ItemEventForm())
            {
                var result = win.ShowDialog();
                if(result == DialogResult.OK)
                {
                    trigger = new TriggerItem(win.comboBoxItems.Text,
                        win.comboBoxFirst.Text, win.comboBoxSecond.Text, win.idTrigger);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void buttonThingEvent_Click(object sender, EventArgs e)
        {
            using (var win = new ThingEventForm())
            {
                var result = win.ShowDialog();
                if (result == DialogResult.OK)
                {
                    trigger = new TriggerThing(win.comboBoxThings.Text,
                        win.comboBoxFirst.Text, win.comboBoxSecond.Text, win.idTrigger);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void buttonTimeEvent_Click(object sender, EventArgs e)
        {
            using (var win = new TimeEventForm())
            {
                var result = win.ShowDialog();
                if (result == DialogResult.OK)
                {
                    trigger = new TriggerTime(win.textBoxTime.Text, win.idTrigger);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void buttonSystemEvent_Click(object sender, EventArgs e)
        {
            using (var win = new SystemEventForm())
            {
                var result = win.ShowDialog();
                if (result == DialogResult.OK)
                {
                    trigger = new TriggerSystem(win.idTrigger);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void pictureBoxCancel_MouseLeave(object sender, EventArgs e)
        {
            //this.pictureBoxCancel.BorderStyle = BorderStyle.None;
        }

        private void pictureBoxCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pictureBoxCancel_MouseEnter(object sender, EventArgs e)
        {
            //this.pictureBoxCancel.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
