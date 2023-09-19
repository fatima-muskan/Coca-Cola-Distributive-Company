using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.DL;

namespace FinalProject
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void pnl_login_Paint(object sender, PaintEventArgs e)
        {
            pnl_login.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void checkBox_Show_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Show.Checked)
            {
                txtBox_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txtBox_pass.UseSystemPasswordChar = true;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string role=LoginDL.CheckUser(int.Parse(txtBox_username.Text), txtBox_pass.Text);
            if (txtBox_username.Text.Trim() == "" && txtBox_pass.Text.Trim() == "")
            {
                string message = "Please enter User Name and Password";
                string title = "Login Window";
                MessageBox.Show(message, title);
            }
            else if (role=="Sales Manager")
            {
                string message = ("You are Successfully Login");
                string title = "Login Window";
                MessageBox.Show(message, title);
                
                form_salesManager m = new form_salesManager();
                m.Show();
                this.Hide();
            }
            else if (role == "Inventory Manager")
            {
                string message = ("You are Successfully Login");
                string title = "Login Window";
                MessageBox.Show(message, title);

                form_inventoryManager m = new form_inventoryManager();
                m.Show();
                this.Hide();
            }
            else if (role == "General Manager")
            {
                string message = ("You are Successfully Login");
                string title = "Login Window";
                MessageBox.Show(message, title);

                form_generalManager m = new form_generalManager();
                m.Show();
                this.Hide();
            }
            else if (role == "Manager")
            {
                string message = ("You are Successfully Login");
                string title = "Login Window";
                MessageBox.Show(message, title);

                form_manager m = new form_manager();
                m.Show();
                this.Hide();
            }
            else if (role == "Rider")
            {
                string message = ("You are Successfully Login");
                string title = "Login Window";
                MessageBox.Show(message, title);

                form_rider m = new form_rider();
                m.Show();
                this.Hide();
            }
            else if(role==null)
            {
                string message = ("UserName or Password is not correct.");
                string title = "Login Window";
                MessageBox.Show(message, title);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.ExitThread();
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
