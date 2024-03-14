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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            room1 room1 = new room1();
            room1.Show();
        }

        private void onFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
