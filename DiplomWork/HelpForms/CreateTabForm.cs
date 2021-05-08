using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomWork.HelpForms
{
    public partial class CreateTabForm : System.Windows.Forms.Form
    {
        public CreateTabForm()
        {
            InitializeComponent();
            this.textBoxTab.Select();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBoxTab_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.buttonOk.PerformClick();
            }
        }

        private void textBoxTab_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
