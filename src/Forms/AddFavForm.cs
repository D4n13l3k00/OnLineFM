using System;
using System.Windows.Forms;

namespace OnLineFM
{
    public partial class AddFavForm : Form
    {
        public bool entered = false;
        public AddFavForm()
        {
            InitializeComponent();
            entered = false;
        }

        private void playbtn_Click(object sender, EventArgs e)
        {
            if (namebox.Text == String.Empty || urlbox.Text == String.Empty) {
                MessageBox.Show("Enter name and url!", "Hey!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            entered = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
