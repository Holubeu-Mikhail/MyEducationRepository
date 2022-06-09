using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lbl_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Close_MouseEnter(object sender, EventArgs e)
        {
            this.lbl_Close.ForeColor = Color.Red;
        }

        private void lbl_Close_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_Close.ForeColor = Color.White;
        }
    }
}
