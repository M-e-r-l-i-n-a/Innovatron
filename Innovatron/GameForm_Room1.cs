using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Innovatron
{
    public partial class GameForm_Room1 : Form
    {
        bool moveLeft, moveRight;
        int speed = 12;
        bool gotKey;

        public GameForm_Room1()
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
                GameForm_Room2 newRoom = new GameForm_Room2();
                this.Hide();
                moveTimer.Stop();
                gotKey = false;
                newRoom.Show();
            }
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
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

        private void KeyIsUp(object sender, KeyEventArgs e)
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

        private void roboter_Click(object sender, EventArgs e)
        {

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void key_Click(object sender, EventArgs e)
        {

        }
    }
}
