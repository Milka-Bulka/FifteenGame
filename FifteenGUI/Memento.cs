using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenGUI
{
    class Memento
    {
        int x0, y0;
        public Memento(int x, int y)
        {
            this.x0 = x;
            this.y0 = y;
        }
        public (int, int) GetState()
        {
            return (x0, y0);
        }
    }
}
