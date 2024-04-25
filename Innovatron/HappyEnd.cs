using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Innovatron
{
    public partial class HappyEnd : Form
    {
        public HappyEnd()
        {
            InitializeComponent();
        }

        private void HappyEnd_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void HappyEnd_Shown(object sender, EventArgs e)
        {
            Program.room1 = new();
            Program.room2 = new();
            Program.room3 = new();
            Program.room4 = new();
            Program.Actions = new() { "cancel", "take" };
        }
    }
}
