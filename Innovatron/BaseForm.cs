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
        Bitmap moveLeftPicture = new("..\\..\\..\\Resources\\moveLeft.png");
        Bitmap moveRightPicture = new("..\\..\\..\\Resources\\moveRight.png");
        List<PictureBox> interactionObjects;
        public PictureBox interactionObjekt;
        Control[] actionListElements;
        string selectedAction;

        public BaseForm()
        {
            InitializeComponent();

            PictureBox[] allInteractionObjects = { key, door1, door2, door3, cupboard, glasses, paper, schloss, wireCutter, box, table };

            actionListElements = new Control[]{ labelAction, selectAction, ActionsList };

            foreach (PictureBox interactionObject in allInteractionObjects)
            {
                interactionObject.Visible = false;
            }

            foreach (Control actionObject in actionListElements)
            {
                actionObject.Visible = false;
            }

            interactionObjects = InteractionObjects();

            foreach (PictureBox interactionObject in interactionObjects)
            {
                interactionObject.Visible = true;
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

            ActionsList.Items.Clear();

            foreach (string action in Program.Actions)
            {
                ActionsList.Items.Add(action);
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

        public virtual List<PictureBox> InteractionObjects()
        {
            List<PictureBox> interactionObjects = new();
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
            this.Focus();
        }

        public virtual void DefineActions()
        {
            
        }

        public void ActionObject(PictureBox objekt, string requiredAction, string getAction)
        {
            if (interactionObjekt == objekt && selectedAction == requiredAction)
            {
                Program.Actions.Add(getAction);
                objekt.Left = -100;
            }
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

        public void RevealObject(PictureBox objekt, string requiredAction, PictureBox activateObject, string changePicture)
        {
            if (interactionObjekt == objekt && selectedAction == requiredAction)
            {
                interactionObjects.Add(activateObject);
                interactionObjects.Remove(objekt);
                activateObject.Visible = true;

                if (changePicture != "")
                {
                    Bitmap picture = new(changePicture);
                    objekt.Image = picture;
                } else
                {
                    objekt.Left = -200;
                }
            }
        }

        private void helpbutton_Click(object sender, EventArgs e)
        {
            GetHelpForm getHelpForm = new GetHelpForm();
            getHelpForm.ShowDialog();
        }
    }
}
