using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomWork.Triggers
{
    class TriggerTime : Trigger
    {

        public TriggerTime(string time, ushort idTrigger)
        {
            this.time = time;
            this.idTrigger = idTrigger;
        }
    }
}
