using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiplomWork.Actions;

namespace DiplomWork.ActionForms
{
    public partial class ItemActionForm : System.Windows.Forms.Form
    {
        protected List<string> _itemList;
        protected List<string> _stateList = new List<string> { "CLOSED", "OPEN", "DOWN", "UP", "OFF", "ON" };

        public ushort idTrigger;
        public ItemActionForm()
        {
            _itemList = Form.itemList;
            InitializeComponent();
            for (int i = 0; i < _itemList.Count; i++)
            {
                this.comboBoxItems.Items.Add(_itemList[i]);
            }

            /*for (int i = 0; i < _stateList.Count; i++)
            {
                this.comboBoxCommand.Items.Add(_stateList[i]);
            }*/
        }

        public ItemActionForm(MyAction action) : this()
        {
            this.comboBoxItems.Text = action.device;
            //this.comboBoxCommand.Text = action.state;
            this.textBoxState.Text = action.state;
            switch (action.idTrigger)
            {
                case 0:
                    this.radioButtonSendCommand.Checked = true;
                    break;
                case 1:
                    this.radioButtonStateUpdate.Checked = true;
                    break;
            }
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void radioButtonSendCommand_CheckedChanged(object sender, EventArgs e)
        {
            this.labelFirst.Text = "Команда";
            this.labelSecond.Visible = false;
            this.idTrigger = 0;
        }

        private void radioButtonStateUpdate_CheckedChanged(object sender, EventArgs e)
        {
            this.labelFirst.Text = "Cостояние";
            this.labelSecond.Visible = false;
            this.idTrigger = 1;
        }
    }
}
