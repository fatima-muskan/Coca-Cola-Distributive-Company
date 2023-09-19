using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class form_rider : Form
    {
        public form_rider()
        {
            InitializeComponent();
        }

        private void btn_collectOrder_Click(object sender, EventArgs e)
        {
            form_collectOrder m=new form_collectOrder();
            m.Show();
            this.Hide();
        }

        private void btn_placeOrder_Click(object sender, EventArgs e)
        {
            form_placeOrder m = new form_placeOrder();
            m.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            loginForm m = new loginForm();
            m.Show();
            this.Hide();
        }
    }
}
