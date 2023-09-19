namespace FinalProject
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.tlp_login = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_softdrink = new System.Windows.Forms.Label();
            this.checkBox_Show = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txtBox_pass = new System.Windows.Forms.TextBox();
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.tlp_login.SuspendLayout();
            this.pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_login
            // 
            this.tlp_login.BackgroundImage = global::FinalProject.Properties.Resources.Log;
            this.tlp_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlp_login.ColumnCount = 1;
            this.tlp_login.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_login.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_login.Controls.Add(this.pnl_login, 0, 0);
            this.tlp_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_login.Location = new System.Drawing.Point(0, 0);
            this.tlp_login.Name = "tlp_login";
            this.tlp_login.RowCount = 1;
            this.tlp_login.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_login.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_login.Size = new System.Drawing.Size(664, 410);
            this.tlp_login.TabIndex = 0;
            // 
            // pnl_login
            // 
            this.pnl_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_login.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_login.Controls.Add(this.lbl_pass);
            this.pnl_login.Controls.Add(this.lbl_userName);
            this.pnl_login.Controls.Add(this.lbl_softdrink);
            this.pnl_login.Controls.Add(this.checkBox_Show);
            this.pnl_login.Controls.Add(this.btn_login);
            this.pnl_login.Controls.Add(this.btn_exit);
            this.pnl_login.Controls.Add(this.txtBox_pass);
            this.pnl_login.Controls.Add(this.txtBox_username);
            this.pnl_login.Location = new System.Drawing.Point(161, 67);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(341, 275);
            this.pnl_login.TabIndex = 2;
            this.pnl_login.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_login_Paint);
            // 
            // lbl_pass
            // 
            this.lbl_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_pass.Location = new System.Drawing.Point(60, 129);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(84, 21);
            this.lbl_pass.TabIndex = 23;
            this.lbl_pass.Text = "Password";
            // 
            // lbl_userName
            // 
            this.lbl_userName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_userName.Location = new System.Drawing.Point(60, 78);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(88, 21);
            this.lbl_userName.TabIndex = 22;
            this.lbl_userName.Text = "UserName";
            // 
            // lbl_softdrink
            // 
            this.lbl_softdrink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_softdrink.AutoSize = true;
            this.lbl_softdrink.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_softdrink.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_softdrink.Location = new System.Drawing.Point(7, 22);
            this.lbl_softdrink.Name = "lbl_softdrink";
            this.lbl_softdrink.Size = new System.Drawing.Size(327, 28);
            this.lbl_softdrink.TabIndex = 21;
            this.lbl_softdrink.Text = "Soft Drink Management System";
            // 
            // checkBox_Show
            // 
            this.checkBox_Show.AutoSize = true;
            this.checkBox_Show.ForeColor = System.Drawing.Color.RoyalBlue;
            this.checkBox_Show.Location = new System.Drawing.Point(168, 179);
            this.checkBox_Show.Name = "checkBox_Show";
            this.checkBox_Show.Size = new System.Drawing.Size(102, 17);
            this.checkBox_Show.TabIndex = 20;
            this.checkBox_Show.Text = "Show Password";
            this.checkBox_Show.UseVisualStyleBackColor = true;
            this.checkBox_Show.CheckedChanged += new System.EventHandler(this.checkBox_Show_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Silver;
            this.btn_login.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(223, 212);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 40);
            this.btn_login.TabIndex = 19;
            this.btn_login.Text = "     LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Silver;
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(33, 212);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(77, 40);
            this.btn_exit.TabIndex = 18;
            this.btn_exit.Text = "   EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // txtBox_pass
            // 
            this.txtBox_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBox_pass.Location = new System.Drawing.Point(80, 153);
            this.txtBox_pass.Name = "txtBox_pass";
            this.txtBox_pass.Size = new System.Drawing.Size(190, 20);
            this.txtBox_pass.TabIndex = 17;
            this.txtBox_pass.UseSystemPasswordChar = true;
            // 
            // txtBox_username
            // 
            this.txtBox_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBox_username.Location = new System.Drawing.Point(80, 102);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(190, 20);
            this.txtBox_username.TabIndex = 16;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 410);
            this.Controls.Add(this.tlp_login);
            this.Name = "loginForm";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.tlp_login.ResumeLayout(false);
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_login;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_softdrink;
        private System.Windows.Forms.CheckBox checkBox_Show;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txtBox_pass;
        private System.Windows.Forms.TextBox txtBox_username;
    }
}

