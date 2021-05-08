using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomWork.Triggers
{
    class TriggerIf : Trigger
    {
        public TriggerIf(string device, string state, ushort id)
        {
            this.device = device;
            this.state = state;
            this.idTrigger = id;
        }
    }
}
