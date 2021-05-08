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
    public partial class ItemIfForm : System.Windows.Forms.Form
    {
        protected List<string> _itemList;
        //protected List<string> _stateList = new List<string> { "CLOSED", "OPEN", "DOWN", "UP", "OFF", "ON" };

        public ushort idTrigger;
        public ItemIfForm()
        {
            _itemList = Form.itemList;
            InitializeComponent();
            for (int i = 0; i < _itemList.Count; i++)
            {
                this.comboBoxItems.Items.Add(_itemList[i]);
            }
        }

        public ItemIfForm(Trigger trigger) : this()
        {
            this.comboBoxItems.Text = trigger.device;
            this.textBoxState.Text = trigger.state;
            switch (trigger.idTrigger)
            {
                case 0:
                    this.radioButtonEqual.Checked = true;
                    break;
                case 1:
                    this.radioButtonNotEqual.Checked = true;
                    break;
                case 2:
                    this.radioButtonGrater.Checked = true;
                    break;
                case 3:
                    this.radioButtonGreaterEqual.Checked = true;
                    break;
                case 4:
                    this.radioButtonLess.Checked = true;
                    break;
                case 5:
                    this.radioButtonLessEqual.Checked = true;
                    break;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (this.comboBoxItems.Text == "")
            {
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void radioButtonEqual_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
