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
    public partial class form_inventoryManager : Form
    {
        public form_inventoryManager()
        {
            InitializeComponent();
        }

        private void btn_addsupplier_Click(object sender, EventArgs e)
        {
            form_addSupplier m = new form_addSupplier();
            m.Show();
            this.Hide();
        }

        private void btn_viewsupplier_Click(object sender, EventArgs e)
        {
            form_viewSupplier m = new form_viewSupplier();
            m.Show();
            this.Hide();
        }

        private void btn_searchsupplier_Click(object sender, EventArgs e)
        {
            form_searchSupplier m = new form_searchSupplier();
            m.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            loginForm m = new loginForm();
            m.Show();
            this.Hide();
        }

        private void btn_addstock_Click(object sender, EventArgs e)
        {
            form_addItem m = new form_addItem();
            m.Show();
            this.Hide();
        }

        private void btn_viewStock_Click(object sender, EventArgs e)
        {
            form_extractItem m = new form_extractItem();
            m.Show();
            this.Hide();
        }

        private void btn_searchStock_Click(object sender, EventArgs e)
        {
            form_viewStock m = new form_viewStock();
            m.Show();
            this.Hide();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            form_generateReport m = new form_generateReport();
            m.Show();
            this.Hide();
        }
    }
}
