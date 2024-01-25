using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Innovatron
{
    public partial class GameForm_Room2 : Form
    {

        bool moveLeft, moveRight;
        int speed = 12;
        bool gotKey;

        public GameForm_Room2()
        {
            InitializeComponent();
        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
            if (moveLeft && roboter.Left > 0)
            {
                roboter.Left -= speed;
            }
            if (moveRight && roboter.Left < 922)
            {
                roboter.Left += speed;
            }
            if (key.Bounds.IntersectsWith(roboter.Bounds))
            {
                gotKey = true;
                key.Visible = false;
            }
            if (door.Bounds.IntersectsWith(roboter.Bounds) && gotKey)
            {
                GameForm_Room1 newRoom = new GameForm_Room1();
                this.Hide();
                gameTimer.Stop();
                gotKey = false;
                newRoom.Show();
            }
        }

        private void GameForm_Room2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void GameForm_Room2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                moveRight = false;
            }
        }

        private void GameForm_Room2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                moveRight = true;
            }
        }
        private void GameForm_Room2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
