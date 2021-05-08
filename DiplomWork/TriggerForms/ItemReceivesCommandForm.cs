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
    public partial class ItemReceivesCommandForm : System.Windows.Forms.Form
    {

        protected List<string> _itemList;
        protected List<string> _stateList = new List<string>{"CLOSED","OPEN","DOWN","UP","OFF","ON"};
        public ItemReceivesCommandForm(List<string> itemList)
        {
            _itemList = itemList;
            InitializeComponent();
            for (int i = 0; i < _itemList.Count; i++)
            {
                this.comboBoxItems.Items.Add(_itemList[i]);
            }

            for (int i = 0; i < _stateList.Count; i++)
            {
                this.comboBoxState.Items.Add(_stateList[i]);
            }
        }

        public ItemReceivesCommandForm(List<string> itemList, string item, string state)
        {
            _itemList = itemList;
            InitializeComponent();
            for (int i = 0; i < _itemList.Count; i++)
            {
                this.comboBoxItems.Items.Add(_itemList[i]);
            }

            for (int i = 0; i < _stateList.Count; i++)
            {
                this.comboBoxState.Items.Add(_stateList[i]);
            }
            this.comboBoxItems.Text = item;
            this.comboBoxState.Text = state;
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
