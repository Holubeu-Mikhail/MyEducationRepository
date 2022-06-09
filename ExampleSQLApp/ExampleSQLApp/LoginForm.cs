using ExampleSQLApp.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class LoginForm : Form
    {
        private Point _downPoint = Point.Empty;
        private const string EnterUsernameString = "Enter username";
        private const string EnterPasswordString = "Enter password";

        public LoginForm()
        {
            InitializeComponent();

            this.txtBox_Username.Text = EnterUsernameString;
            this.txtBox_Username.ForeColor = Color.Gray;
            this.txtBox_Password.UseSystemPasswordChar = false;
            this.txtBox_Password.Text = EnterPasswordString;
            this.txtBox_Password.ForeColor = Color.Gray;

            this.txtBox_Password.AutoSize = false;
            this.txtBox_Password.Size = new Size(this.txtBox_Password.Size.Width, this.txtBox_Username.Size.Height);
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

        private void pnl_Main_MouseMove(object sender, MouseEventArgs e)
        {
            Utilities.MoveWindow(e, _downPoint, this);
        }

        private void lbl_Authorization_MouseMove(object sender, MouseEventArgs e)
        {
            Utilities.MoveWindow(e, _downPoint, this);
        }

        private void pnl_Main_MouseDown(object sender, MouseEventArgs e)
        {
            const bool isUp = false;
            _downPoint = Utilities.GetDownPoint(e, isUp);
        }

        private void pnl_Main_MouseUp(object sender, MouseEventArgs e)
        {
            const bool isUp = true;
            _downPoint = Utilities.GetDownPoint(e, isUp);
        }

        private void lbl_Authorization_MouseDown(object sender, MouseEventArgs e)
        {
            const bool isUp = false;
            _downPoint = Utilities.GetDownPoint(e, isUp);
        }

        private void lbl_Authorization_MouseUp(object sender, MouseEventArgs e)
        {
            const bool isUp = true;
            _downPoint = Utilities.GetDownPoint(e, isUp);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var username = txtBox_Username.Text;
            var password = txtBox_Password.Text;

            var dbHelper = new DbHelper();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();

            var command = new MySqlCommand("SELECT * FROM `users` WHERE `Username` = @username AND `Password` = @password", dbHelper.GetConnection());
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                var form = new MainForm();
                form.Show();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect");
            }
        }

        private void txtBox_Username_Enter(object sender, EventArgs e)
        {
            if (txtBox_Username.Text == EnterUsernameString)
            {
                txtBox_Username.Text = "";
                txtBox_Username.ForeColor = Color.Black;
            }
        }

        private void txtBox_Username_Leave(object sender, EventArgs e)
        {
            if (txtBox_Username.Text == "")
            {
                txtBox_Username.Text = EnterUsernameString;
                txtBox_Username.ForeColor = Color.Gray;
            }
        }

        private void txtBox_Password_Enter(object sender, EventArgs e)
        {
            if (txtBox_Password.Text == EnterPasswordString)
            {
                txtBox_Password.UseSystemPasswordChar = true;
                txtBox_Password.Text = "";
                txtBox_Password.ForeColor = Color.Black;
            }
        }

        private void txtBox_Password_Leave(object sender, EventArgs e)
        {
            if (txtBox_Password.Text == "")
            {
                txtBox_Password.UseSystemPasswordChar = false;
                txtBox_Password.Text = EnterPasswordString;
                txtBox_Password.ForeColor = Color.Gray;
            }
        }

        private void lbl_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new RegistrationForm();

            form.Show();
        }

        private void lbl_Register_MouseEnter(object sender, EventArgs e)
        {
            this.lbl_Register.ForeColor = Color.Red;
        }

        private void lbl_Register_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_Register.ForeColor = Color.FromArgb(255, 240, 163, 161);
        }
    }
}
