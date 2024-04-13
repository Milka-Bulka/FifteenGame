using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentLibrary
{
    public partial class GameTimer: UserControl
    {
        int h = 0;
        int m = 0;
        int s = 0;

        string time = "00:00:00";
        public GameTimer()
        {
            InitializeComponent();
        }
        public void Start()
        {
            //display.Text = time;
            timer.Enabled = true;
        }
        public void Stop()
        {
            timer.Enabled = false;
            display.Text = "Время: " + time;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //time = "";
            //if (h < 10)
            //    time += "0" + h;
            //else
            //    time += h;
            //time += ":";
            //if (m < 10)
            //    time += "0" + m;
            //else
            //    time += m;
            //time += ":";
            //if (s < 10)
            //    time += "0" + s;
            //else
            //    time += s;

            time = "";
            s += 1;
            if (s == 60)
            {
                m += 1;
                s = 0;
            }
            if (m == 60)
            {
                h += 1;
                m = 0;
            }
            if (h < 10)
                time += "0" + h;
            else
                time += h;
            time += ":";
            if (m < 10)
                time += "0" + m;
            else
                time += m;
            time += ":";
            if (s < 10)
                time += "0" + s;
            else
                time += s;
            display.Text = "Время: " + time;
            //GetDisplay();
        }
        public string GetDisplay() => display.Text;
    }
}
