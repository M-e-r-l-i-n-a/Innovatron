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
using static System.Net.Mime.MediaTypeNames;

namespace Innovatron
{
    public partial class BaseForm : Form
    {
        bool moveLeft, moveRight;
        int speed = 12;
        Bitmap moveLeftPicture = new("..\\..\\..\\pictures\\moveLeft.png");
        Bitmap moveRightPicture = new("..\\..\\..\\pictures\\moveRight.png");
        PictureBox[] interactionObjects;
        PictureBox interactionObjekt;
        Control[] actionListElements;
        string selectedAction;

        public BaseForm()
        {
            InitializeComponent();

            PictureBox[] allInteractionObjects = { key, door1, door2, door3, cupboard, glasses, paper };

            actionListElements = new Control[]{ labelAction, selectAction, ActionsList };

            interactionObjects = InteractionObjects();

            foreach (PictureBox interactionObject in allInteractionObjects)
            {
                interactionObject.Visible = false;
            }

            foreach (Control actionObject in actionListElements)
            {
                actionObject.Visible = false;
            }

            foreach (PictureBox interactionObject in interactionObjects)
            {
                interactionObject.Visible = true;
            }

            foreach (string action in Program.Actions)
            {
                ActionsList.Items.Add(action);
            }
        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
            if (moveLeft && player.Left > 0)
            {
                player.Left -= speed;
                if (player.Image != moveLeftPicture)
                {
                    player.Image = moveLeftPicture;
                }
            }
            if (moveRight && player.Left < 924)
            {
                player.Left += speed;
                if (player.Image != moveRightPicture)
                {
                    player.Image = moveRightPicture;
                }
            }
            if (interactionObjekt != null)
            {
                if (!player.Bounds.IntersectsWith(interactionObjekt.Bounds))
                {
                    interactionObjekt = null;
                }
            }
        }

        public void showActions(PictureBox _interactionObject)
        {
            interactionObjekt = _interactionObject;
            moveRight = false;
            moveLeft = false;

            foreach (Control actionObject in actionListElements)
            {
                actionObject.Visible = true;
            }
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            text.Text = "";
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                foreach (PictureBox obj in interactionObjects)
                {
                    if (obj.Bounds.IntersectsWith(player.Bounds))
                    {
                        showActions(obj);
                    }
                }
            }
        }

        public virtual PictureBox[] InteractionObjects()
        {
            PictureBox[] interactionObjects = { };
            return interactionObjects;
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

        public void button1_Click(object sender, EventArgs e)
        {
            SelectItemFromList();
        }

        private void KeyDownList(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                SelectItemFromList();
            }
        }

        private void SelectItemFromList()
        {
            foreach (Control actionObject in actionListElements)
            {
                actionObject.Visible = false;
            }

            selectedAction = (string)ActionsList.SelectedItem;
            DefineActions();
        }

        public virtual void DefineActions()
        {
            
        }

        public void ActionObject(PictureBox objekt, string requiredAction, string getAction)
        {
            if (interactionObjekt == objekt && selectedAction == requiredAction)
            {
                Program.Actions.Add(getAction);
                ActionsList.Items.Add(getAction);
                key.Left = -100;
            }
            this.Focus();
        }

        public void InformationObject(PictureBox objekt, string text)
        {
            if (interactionObjekt == objekt && selectedAction == "read")
            {
                this.text.Text = text;
            }
        }

        public void Door(PictureBox objekt, Form nextForm)
        {
            if (interactionObjekt == objekt && selectedAction == "open")
            {
                this.Hide();
                nextForm.Show();
            }
        }

        private void helpbutton_Click(object sender, EventArgs e)
        {
            GetHelpForm getHelpForm = new GetHelpForm();
            getHelpForm.ShowDialog();
        }
    }
}
