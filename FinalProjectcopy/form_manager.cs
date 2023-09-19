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
    public partial class form_manager : Form
    {
        public form_manager()
        {
            InitializeComponent();
        }

        private void btn_addemp_Click(object sender, EventArgs e)
        {
            form_AddEmployee moreform = new form_AddEmployee();
            moreform.Show();
            this.Hide();
        }

        private void btn_viewemp_Click(object sender, EventArgs e)
        {
            form_viewEmployee moreform = new form_viewEmployee();
            moreform.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            form_searchEmployee moreform = new form_searchEmployee();
            moreform.Show();
            this.Hide();
        }

        private void form_manager_Load(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            loginForm m = new loginForm();
            m.Show();
            this.Hide();
        }

        private void btn_addemp_Click_1(object sender, EventArgs e)
        {
            form_AddEmployee m = new form_AddEmployee();
            m.Show();
            this.Hide();
              
        }

        private void btn_viewemp_Click_1(object sender, EventArgs e)
        {
            form_viewEmployee m = new form_viewEmployee();
            m.Show();
            this.Hide();
        }

        private void btn_searchemp_Click(object sender, EventArgs e)
        {
            form_searchEmployee m = new form_searchEmployee();
            m.Show();
            this.Hide();
        }

        private void btn_addRider_Click(object sender, EventArgs e)
        {
            form_addRider m = new form_addRider();
            m.Show();
            this.Hide();
        }

        private void btn_viewRider_Click(object sender, EventArgs e)
        {
            form_viewRider m = new form_viewRider();
            m.Show();
            this.Hide();
        }

        private void btn_searchRider_Click(object sender, EventArgs e)
        {
            form_searchRider m = new form_searchRider();
            m.Show();
            this.Hide();
        }
    }
}
