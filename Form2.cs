using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noughts_crosses
{
    public partial class Form2 : Form
    {
        public Form2(string _p1, string _p2)
        {
            InitializeComponent();
            label1.Text = _p1;
            label2.Text = _p2;

            int currentPlayer = 1;

            int[,] map = new int[3, 3];

            MessageBox.Show(Convert.ToString(pictureBox1.ImageLocation));
        }

        public bool RowCheck(int playerNum, int[,] map)
        {
            for (int i = 0; i < 3; i++)
            {
                if (map[i, 0] == playerNum && map[i, 1] == playerNum && map[i, 2] == playerNum)
                {
                    return true;
                }
            }

            return false;
        }

        public bool ColCheck(int playerNum, int[,] map)
        {
            for (int i = 0; i < 3; i++)
            {
                if (map[0, i] == playerNum && map[1, i] == playerNum && map[2, i] == playerNum)
                {
                    return true;
                }
            }
            return false;
        }

        public bool DiagCheck(int playerNum, int[,] map)
        {
            if (map[0, 0] == playerNum && map[1, 1] == playerNum && map[2, 2] == playerNum) { return true; }
            else if (map[0, 2] == playerNum && map[1, 1] == playerNum && map[2, 0] == playerNum) { return true; }
            else { return false; }
        }

        public bool boardCheck(int playerNum, int[,] map)
        {
            bool row = RowCheck(playerNum, map);
            bool col = ColCheck(playerNum, map);
            bool diag = DiagCheck(playerNum, map);

            if (row || col || diag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
