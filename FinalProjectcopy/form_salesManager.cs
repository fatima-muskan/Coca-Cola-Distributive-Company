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
    public partial class form_salesManager : Form
    {
        public form_salesManager()
        {
            InitializeComponent();
        }

        private void btn_addVehicle_Click(object sender, EventArgs e)
        {
            form_addVahicle m = new form_addVahicle();
            m.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
           loginForm m = new loginForm();
            m.Show();
            this.Hide();
        }

        private void btn_viewVehicle_Click(object sender, EventArgs e)
        {
            form_viewVahicle m = new form_viewVahicle();
            m.Show();
            this.Hide();
        }

        private void btn_searchVehicle_Click(object sender, EventArgs e)
        {
            form_searchVahicle m = new form_searchVahicle();
            m.Show();
            this.Hide();
        }

        private void btn_addShopkeeper_Click(object sender, EventArgs e)
        {
            form_addShopkeeper m=new form_addShopkeeper();
            m.Show();
            this.Hide();
        }

        private void btn_viewShopkeeper_Click(object sender, EventArgs e)
        {
            form_viewShopkeeper m = new form_viewShopkeeper();
            m.Show();
            this.Hide();
        }

        private void btn_searchShopkeeper_Click(object sender, EventArgs e)
        {
            form_searchShopkeeper m = new form_searchShopkeeper();
            m.Show();
            this.Hide();
        }
    }
}
