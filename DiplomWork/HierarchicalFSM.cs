using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using DiplomWork.UserControls;
using System.Collections;

namespace DiplomWork
{
    public class HierarchicalFSM : IEnumerable
    {

        private List<ControlHierarchicalFSM> _states; // конечный автомат (then в скрипте)
        //private ControlHierarchicalFSM _link; 
        
        private string _device { get; }

        public ControlHierarchicalFSM GetLastState() => _states.Last();

        public ControlHierarchicalFSM GetState(int i) => _states[i];

        public FSM GetLastFSM() => _states.Last().fsm;

        public HierarchicalFSM(string device)
        {
            _states = new List<ControlHierarchicalFSM>();
            //_transition = new ControlHierarchicalFSM();
            _device = device;
        }

        public void AddState(MouseEventArgs e/*, ControlHierarchicalFSM link*/)
        {
            _states.Add(new ControlHierarchicalFSM(e/*, link*/));
        }

        public int WhereMouse()
        {
            for(int i = 0; i < _states.Count; i++)
            {
                if(_states[i].isHere)
                {
                    return i;
                }
            }
            return -1;
        }

        public void PrintState(List<Graphics> pictures, TabControl tabControl, Pen p, MouseEventArgs e)
        {

            //pictures[tabControl.SelectedIndex].DrawRectangle(p, e.X, e.Y, 100, 10);
            //pictures[tabControl.SelectedIndex].DrawRectangle(p, e.X, e.Y, 100, 70);
            //_x = e.X;
            //_y = e.Y;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _states.GetEnumerator();
        }
    }
}
