using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomWork.UserControls
{
    public partial class ControlStateFSM : UserControl
    {
        public ControlStateFSM(MouseEventArgs e, bool isFirst)
        {
            InitializeComponent(e, isFirst);
        }
    }
}
