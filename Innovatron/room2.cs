using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovatron
{
    public partial class room2 : Form
    {
        bool moveLeft, moveRight;
        int speed = 12;
        PictureBox interactionObjekt;
        Bitmap moveLeftPicture = new("..\\..\\..\\pictures\\moveLeft.png");
        Bitmap moveRightPicture = new("..\\..\\..\\pictures\\moveRight.png");
        string selectedAction;

        public room2()
        {
            InitializeComponent();
        }

        private void room2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void player_Click(object sender, EventArgs e)
        {

        }
    }
}
