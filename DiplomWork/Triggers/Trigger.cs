using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomWork.Triggers
{
    public abstract class Trigger
    {
        public string device;
        public string prevState;
        public string state;
        public string time;
        public ushort idTrigger;
        /*public Trigger(string device, string state, string prevState, string time)
        {
            this.device = device;
            this.state = state;
            this.prevState = prevState;
            this.time = time;
        }

        public Trigger(string device, string state) : this(device, state, "", "")//receive a command; was updated
        {

        }

        public Trigger(string device, string prevState, string state) : this(device, state, prevState, "")//changed
        {

        }

        public Trigger(string time) : this("", "", "", time)//timeEvent
        {

        }*/
    }
}
