using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        private void черныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt.BackColor = System.Drawing.Color.Black;
            черныйToolStripMenuItem.Enabled = false;
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt.BackColor = System.Drawing.Color.Red;
            красныйToolStripMenuItem.Enabled = false;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt.BackColor = System.Drawing.Color.Blue;
            синийToolStripMenuItem.Enabled = false;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt.BackColor = System.Drawing.Color.Green;
            зеленыйToolStripMenuItem .Enabled = false;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
