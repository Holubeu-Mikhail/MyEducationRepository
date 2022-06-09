
namespace ExampleSQLApp
{
    partial class MainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.lbl_Authorization = new System.Windows.Forms.Label();
            this.pnl_Main.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnl_Main.Controls.Add(this.panel2);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1048, 672);
            this.pnl_Main.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.lbl_Close);
            this.panel2.Controls.Add(this.lbl_Authorization);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 100);
            this.panel2.TabIndex = 0;
            // 
            // lbl_Close
            // 
            this.lbl_Close.AutoSize = true;
            this.lbl_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Close.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lbl_Close.Location = new System.Drawing.Point(1020, 0);
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
            this.lbl_Authorization.Size = new System.Drawing.Size(1048, 100);
            this.lbl_Authorization.TabIndex = 0;
            this.lbl_Authorization.Text = "Main menu";
            this.lbl_Authorization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 672);
            this.Controls.Add(this.pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.pnl_Main.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.Label lbl_Authorization;
    }
}