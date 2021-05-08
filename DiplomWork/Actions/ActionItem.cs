using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomWork.Actions
{
    class ActionItem : MyAction
    {
        public ActionItem(string device, string state, ushort id)
        {
            this.device = device;
            this.state = state;
            this.idTrigger = id;
        }
    }
}
