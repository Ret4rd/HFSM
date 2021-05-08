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
    public class FSM : IEnumerable
    {
        private List<ControlStateFSM> _states; 
        private string _transition;
        

        public FSM()
        {
            _states = new List<ControlStateFSM> { }; // код if
            _transition = string.Empty; // if()
            //_scriptName = string.Empty;
        }

        public ControlStateFSM GetLastState() => _states.Last();

        public ControlStateFSM GetFirst() => _states.First();

        public void AddState(MouseEventArgs e)
        {
            if(_states.Count == 0)
            {
                _states.Add(new ControlStateFSM(e, true));
            }
            else
            {
                _states.Add(new ControlStateFSM(e, false));
                _states.First().link.Add(_states.Last());
            }
            
        }

        /*public void DeleteState()
        {
            if (_states.Count == 0)
            {
                _states.Add(new ControlStateFSM(e, true));
            }
            else
            {
                _states.Add(new ControlStateFSM(e, false));
                _states.First().link.Add(_states.Last());
            }
        }*/

        public void PrintState(List<Graphics> pictures, TabControl tabControl, Pen p, MouseEventArgs e)
        {
            //pictures[tabControl.SelectedIndex].DrawRectangle(p, e.X, e.Y, 60, 10);
            //pictures[tabControl.SelectedIndex].DrawRectangle(p, e.X, e.Y, 60, 40);
            //_x = e.X;
            //_y = e.Y;
        }

        public IEnumerator GetEnumerator()
        {
            return _states.GetEnumerator();
        }
    }
}
