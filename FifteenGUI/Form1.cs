using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentLibrary;
using System.Media;

namespace FifteenGUI
{
    public partial class Fifteen : Form
    {
        Game game;
        GameTimer timer;
        int Move;
        private SoundPlayer sp;
        public Fifteen()
        {
            InitializeComponent();
            game = new Game(4);
            timer = new GameTimer();
            sp = new SoundPlayer(@"C:\Users\C#\FifteenGame2222\FifteenGUI\bulk.wav");
        }
        private yt_button GetButton(int index)
        {
            switch (index)
            {
                case 0: return yt_button0;
                case 1: return yt_button1;
                case 2: return yt_button2;
                case 3: return yt_button3;
                case 4: return yt_button4;
                case 5: return yt_button5;
                case 6: return yt_button6;
                case 7: return yt_button7;
                case 8: return yt_button8;
                case 9: return yt_button9;
                case 10: return yt_button10;
                case 11: return yt_button11;
                case 12: return yt_button12;
                case 13: return yt_button13;
                case 14: return yt_button14;
                case 15: return yt_button15;
                default: return null;
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            GameStart();
        }
        private void RefreshButtonField()
        {
            for (int position = 0; position < 16; position++)
            {
                GetButton(position).Text = game.GetNumber(position).ToString();
                GetButton(position).Visible = (game.GetNumber(position) > 0);
            }
        }
        private void GameStart()
        {
            label1.Text = "Число ходов: 0";
            Move = 0;
            game.Start();
            for (int s = 0; s<4; s++)
            {
                game.ShiftRandom();
            }
            RefreshButtonField();
            timer.Start();
            timer.Text = timer.GetDisplay();
        }
        private void Fifteen_Load(object sender, EventArgs e)
        {
            GameStart();
        }
        private void yt_button0_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt32(((yt_button)sender).Tag);
            if (game.Shift(position))
            {
                Move++;
                sp.Play();
            }
            RefreshButtonField();
            label1.Text = "Число ходов: " + Move;
            if (game.Check())
            {
                timer.Stop();
                Winner win = new Winner();
                win.ShowDialog();
                GameStart();
            }
        }
        private void yt_button1_Click(object sender, EventArgs e)
        {
            yt_button0_Click(sender, e);
        }
        private void yt_button2_Click(object sender, EventArgs e)
        {
            yt_button0_Click(sender, e);
        }
        private void yt_button3_Click(object sender, EventArgs e)
        {
            yt_button0_Click(sender, e);
        }
        private void yt_button4_Click(object sender, EventArgs e)
        {
            yt_button0_Click(sender, e);
        }
        private void yt_button5_Click(object sender, EventArgs e)
        {
            yt_button0_Click(sender, e);
        }
        private void yt_button6_Click(object sender, EventArgs e)
        {
            yt_button0_Click(sender, e);
        }
        private void yt_button7_Click(object sender, EventArgs e)
        {
            yt_button0_Click(sender, e);
        }
        private void yt_button8_Click(object sender, EventArgs e)
        {
            yt_button0_Click(sender, e);
        }
        private void yt_button9_Click(object sender, EventArgs e)
        {
            yt_button0_Click(sender, e);
        }
        private void yt_button10_Click(object sender, EventArgs e)
        {
            yt_button0_Click(sender, e);
        }
        private void yt_button11_Click(object sender, EventArgs e)
        {
            yt_button0_Click(sender, e);
        }
        private void yt_button12_Click(object sender, EventArgs e)
        {
            yt_button0_Click(sender, e);
        }
        private void yt_button13_Click(object sender, EventArgs e)
        {
            yt_button0_Click(sender, e);
        }
        private void yt_button14_Click(object sender, EventArgs e)
        {
            yt_button0_Click(sender, e);
        }
        private void yt_button15_Click(object sender, EventArgs e)
        {
            yt_button0_Click(sender, e);
        }
        private void otmena_Click(object sender, EventArgs e)
        {
            game.Otmena();
            RefreshButtonField();
        }
    }
}
