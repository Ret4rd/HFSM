using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomWork.Triggers
{
    public class TriggerItem : Trigger
    {

        public TriggerItem(string device, string state, string prevState, ushort id)
        {
            this.device = device;
            this.state = state;
            this.prevState = prevState;
            this.idTrigger = id;
        }
    }
}
