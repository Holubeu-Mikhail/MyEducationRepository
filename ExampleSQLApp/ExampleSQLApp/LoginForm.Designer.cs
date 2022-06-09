using System;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lbl_Register = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBox_Username = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.lbl_Authorization = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_Main.Controls.Add(this.lbl_Register);
            this.pnl_Main.Controls.Add(this.btn_Login);
            this.pnl_Main.Controls.Add(this.txtBox_Password);
            this.pnl_Main.Controls.Add(this.pictureBox2);
            this.pnl_Main.Controls.Add(this.txtBox_Username);
            this.pnl_Main.Controls.Add(this.pictureBox1);
            this.pnl_Main.Controls.Add(this.panel2);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(456, 463);
            this.pnl_Main.TabIndex = 0;
            this.pnl_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Main_MouseDown);
            this.pnl_Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Main_MouseMove);
            this.pnl_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Main_MouseUp);
            // 
            // lbl_Register
            // 
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Register.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(163)))), ((int)(((byte)(161)))));
            this.lbl_Register.Location = new System.Drawing.Point(152, 434);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(153, 20);
            this.lbl_Register.TabIndex = 6;
            this.lbl_Register.Text = "Haven\'t account yet?";
            this.lbl_Register.Click += new System.EventHandler(this.lbl_Register_Click);
            this.lbl_Register.MouseEnter += new System.EventHandler(this.lbl_Register_MouseEnter);
            this.lbl_Register.MouseLeave += new System.EventHandler(this.lbl_Register_MouseLeave);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_Login.Location = new System.Drawing.Point(48, 357);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(357, 64);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Confirm";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Password.Location = new System.Drawing.Point(118, 250);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(287, 50);
            this.txtBox_Password.TabIndex = 4;
            this.txtBox_Password.UseSystemPasswordChar = true;
            this.txtBox_Password.Enter += new System.EventHandler(this.txtBox_Password_Enter);
            this.txtBox_Password.Leave += new System.EventHandler(this.txtBox_Password_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ExampleSQLApp.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(48, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // txtBox_Username
            // 
            this.txtBox_Username.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Username.Location = new System.Drawing.Point(118, 155);
            this.txtBox_Username.Multiline = true;
            this.txtBox_Username.Name = "txtBox_Username";
            this.txtBox_Username.Size = new System.Drawing.Size(287, 64);
            this.txtBox_Username.TabIndex = 2;
            this.txtBox_Username.UseSystemPasswordChar = true;
            this.txtBox_Username.Enter += new System.EventHandler(this.txtBox_Username_Enter);
            this.txtBox_Username.Leave += new System.EventHandler(this.txtBox_Username_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExampleSQLApp.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(48, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.lbl_Close);
            this.panel2.Controls.Add(this.lbl_Authorization);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 100);
            this.panel2.TabIndex = 0;
            // 
            // lbl_Close
            // 
            this.lbl_Close.AutoSize = true;
            this.lbl_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Close.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lbl_Close.Location = new System.Drawing.Point(428, 0);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(28, 30);
            this.lbl_Close.TabIndex = 1;
            this.lbl_Close.Text = "X";
            this.lbl_Close.Click += new System.EventHandler(this.lbl_Close_Click);
            this.lbl_Close.MouseEnter += new System.EventHandler(this.lbl_Close_MouseEnter);
            this.lbl_Close.MouseLeave += new System.EventHandler(this.lbl_Close_MouseLeave);
            // 
            // lbl_Authorization
            // 
            this.lbl_Authorization.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Authorization.Font = new System.Drawing.Font("Humnst777 BlkCn BT", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Authorization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lbl_Authorization.Location = new System.Drawing.Point(0, 0);
            this.lbl_Authorization.Name = "lbl_Authorization";
            this.lbl_Authorization.Size = new System.Drawing.Size(456, 100);
            this.lbl_Authorization.TabIndex = 0;
            this.lbl_Authorization.Text = "Authorization";
            this.lbl_Authorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Authorization.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_Authorization_MouseDown);
            this.lbl_Authorization.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_Authorization_MouseMove);
            this.lbl_Authorization.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_Authorization_MouseUp);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 463);
            this.Controls.Add(this.pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Authorization;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtBox_Username;
        private System.Windows.Forms.Button btn_Login;
        private Label lbl_Register;
    }
}