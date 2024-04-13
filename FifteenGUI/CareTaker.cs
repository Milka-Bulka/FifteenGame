using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenGUI
{
    class CareTaker
    {
        public Stack<Memento> history = new Stack<Memento>();
        public void SaveState(Memento memento)
        {
            history.Push(memento);
        }
        public Memento PopState()
        {
            if (history.Count > 1)
            {
                history.Pop();
                return history.Pop();
            }
            else
                return null;
        }
    }
}
