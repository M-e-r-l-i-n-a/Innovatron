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
            Program.room1.Show();
            GameOver gameOver = new GameOver();
            gameOver.Show();
        }

        private void onFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
