using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifteenGUI
{
    public class Game
    {
        int[,] field;
        int size;
        int x0, y0;
        CareTaker move = new CareTaker();
        static Random rand = new Random();
        public Game(int n)
        {
            size = n;
            field = new int[size, size];
        }
        private int CoordinatesToPosition(int x, int y)
        {
            return y * size + x;
        }
        private void PositionToCoordinates(int position, out int x, out int y)
        {
            x = position % size;
            y = position / size;
            if (x < 0) x = 0;
            if (y < 0) y = 0;
            if (x > 3) x = 3;
            if (y > 3) y = 3;
        }
        public void Start()
        {
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    field[x, y] = CoordinatesToPosition(x, y) + 1;
                }
            }
            x0 = size - 1;
            y0 = size - 1;
            field[x0, y0] = 0;
        }
        public int GetNumber(int position)
        {
            int x, y;
            PositionToCoordinates(position, out x, out y);
            if (x < 0 || x >= size)
                return 0;
            if (y < 0 || y >= size)
                return 0;
            return field[x, y];
        }
        public bool Shift(int position)
        {
            int x, y;
            PositionToCoordinates(position, out x, out y);
            if (Math.Abs(x0 - x) + Math.Abs(y0 - y) == 1)
            {
                field[x0, y0] = field[x, y];
                field[x, y] = 0;
                x0 = x;
                y0 = y;
                move.SaveState(new Memento(x0, y0));
                return true;
            }
            else
                return false;
        }
        public void ShiftRandom()
        {
            int a = rand.Next(0, 4);
            int x = x0;
            int y = y0;
            switch (a)
            {
                case 0: x--; break;
                case 1: x++; break;
                case 2: y--; break;
                case 3: y++; break;
            }
            Shift(CoordinatesToPosition(x, y));
        }
        public bool Check()
        {
            int h = 0;
            if (field[3, 3] != 0)
                return false;
            else
            {
                for (int x = 0; x < size; x++)
                    for (int y = 0; y < size; y++)
                        if (field[x, y] == CoordinatesToPosition(x, y) + 1)
                            h++;
                if (h == 15)
                    return true;
                return false;
            }
        }
        public void Otmena()
        {
            int position;
            Memento mem;
            mem = move.PopState();
            if (mem != null)
            {
                var (x0, y0) = mem.GetState();
                position = CoordinatesToPosition(x0, y0);
                Shift(position);
            }
        }
    }
}
