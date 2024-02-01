using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovatron
{
    public partial class GameForm : Form
    {
        bool moveLeft, moveRight;
        int speed = 12;
        string interactionObjekt = "";

        public GameForm()
        {
            InitializeComponent();
            ActionsList.Items.Add("cancel");
            ActionsList.Items.Add("take");
            ActionsList.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
            if (moveLeft && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (moveRight && player.Left < 922)
            {
                player.Left += speed;
            }
            if (key.Bounds.IntersectsWith(player.Bounds) && interactionObjekt != "key")
            {
                showActions("key");
            }
            if (!key.Bounds.IntersectsWith(player.Bounds) && interactionObjekt == "key")
            {
                interactionObjekt = "";
            }
        }

        private void showActions(string _interactionObject)
        {
            interactionObjekt = _interactionObject;
            ActionsList.Visible = true;
            button1.Visible = true;
            label1.Visible = true;
            moveRight = false;
            moveLeft = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            SelectItemFromList();
        }

        private void KeyDownList(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectItemFromList();
            }
        }

        private void SelectItemFromList()
        {
            ActionsList.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
            string selectedAction = (string)ActionsList.SelectedItem;
            if (interactionObjekt == "key" && selectedAction == "take")
            {
                ActionsList.Items.Add("open");
                key.Left = -100;
            }
            this.Focus();
        }
    }
}
