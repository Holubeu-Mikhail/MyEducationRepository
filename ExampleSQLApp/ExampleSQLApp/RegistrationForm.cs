using ExampleSQLApp.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections.Generic;
using System.Data;

namespace ExampleSQLApp
{
    public partial class RegistrationForm : Form
    {
        private Point _downPoint = Point.Empty;
        private const string EnterNameString = "Enter name";
        private const string EnterSurnameString = "Enter surname";
        private const string EnterUsernameString = "Enter username";
        private const string EnterPasswordString = "Enter password";

        public RegistrationForm()
        {
            InitializeComponent();

            this.txtBox_UserFirstName.Text = EnterNameString;
            this.txtBox_UserFirstName.ForeColor = Color.Gray;
            this.txtBox_UserLastName.Text = EnterSurnameString;
            this.txtBox_UserLastName.ForeColor = Color.Gray;
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

        private void txtBox_UserFirstName_Enter(object sender, EventArgs e)
        {
            if (txtBox_UserFirstName.Text == EnterNameString)
            {
                txtBox_UserFirstName.Text = "";
                txtBox_UserFirstName.ForeColor = Color.Black;
            }
        }

        private void txtBox_UserLastName_Enter(object sender, EventArgs e)
        {
            if (txtBox_UserLastName.Text == EnterSurnameString)
            {
                txtBox_UserLastName.Text = "";
                txtBox_UserLastName.ForeColor = Color.Black;
            }
        }

        private void txtBox_UserFirstName_Leave(object sender, EventArgs e)
        {
            if (txtBox_UserFirstName.Text == "")
            {
                txtBox_UserFirstName.Text = EnterNameString;
                txtBox_UserFirstName.ForeColor = Color.Gray;
            }
        }

        private void txtBox_UserLastName_Leave(object sender, EventArgs e)
        {
            if (txtBox_UserLastName.Text == "")
            {
                txtBox_UserLastName.Text = EnterSurnameString;
                txtBox_UserLastName.ForeColor = Color.Gray;
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

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txtBox_Username.Text == EnterNameString || txtBox_Password.Text == EnterPasswordString 
                || txtBox_UserFirstName.Text == EnterNameString || txtBox_UserLastName.Text == EnterSurnameString)
            {
                MessageBox.Show("Some field is empty");
                return;
            }

            if (IsUserExists())
            {
                return;
            }

            var db = new DbHelper();

            var command = new MySqlCommand(
                "INSERT INTO `users` (`Username`, `Password`, `Name`, `Surname`) VALUES(@login, @password, @name, @surname)",
                db.GetConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = txtBox_Username.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtBox_Password.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = txtBox_UserFirstName.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = txtBox_UserLastName.Text;
            
            db.OpenConnection();

            MessageBox.Show(command.ExecuteNonQuery() == 1
                ? "Account has been created"
                : "Account hasn't been created");

            db.CloseConnection();
        }

        public bool IsUserExists()
        {
            var dbHelper = new DbHelper();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();

            var command = new MySqlCommand("SELECT * FROM `users` WHERE `Username` = @username", dbHelper.GetConnection());
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtBox_Username.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Username has already been taken");
                return true;
            }
            return false;
        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new LoginForm();

            form.Show();
        }

        private void lbl_Login_MouseEnter(object sender, EventArgs e)
        {
            this.lbl_Login.ForeColor = Color.Red;
        }

        private void lbl_Login_MouseLeave(object sender, EventArgs e)
        {
            this.lbl_Login.ForeColor = Color.FromArgb(255, 240, 163, 161);
        }
    }
}

