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
    public partial class GetHelpForm : Form
    {
        public GetHelpForm()
        {
            InitializeComponent();
        }

        private void GetHelpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
        }

        private void CloseHelpFormBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
