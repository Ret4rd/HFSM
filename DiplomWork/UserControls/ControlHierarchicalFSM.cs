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
    public partial class ControlHierarchicalFSM : UserControl
    {
        
        public ControlHierarchicalFSM(MouseEventArgs e/*, ControlHierarchicalFSM link*/)
        {
            _fsm = new FSM();
            /*this.link = link;*/
            InitializeComponent(e);
        }
    }
}
