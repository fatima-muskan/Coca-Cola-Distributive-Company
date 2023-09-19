using FinalProject.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.BL;
using System.IO;

namespace FinalProject
{
    public partial class form_viewEmployee : Form
    {
        EmployeeDL BST = new EmployeeDL();
       
        public form_viewEmployee()
        {
            InitializeComponent();
        }

        private void GV_viewRider_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           EmployeeBL emp = (EmployeeBL)dataGridView1.CurrentRow.DataBoundItem;
            if (1 == e.ColumnIndex)
            {
                if (MessageBox.Show("Are you sure to delete?", "Confirmation!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BST.Remove(emp);
                    
                }
                if (MessageBox.Show("Do you save in file?", "Confirmation!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<EmployeeBL> list = BST.TreetoList();
                    BST.storeInFile("Employee.csv", list);
                    MessageBox.Show("Store in File!!");
                    
                }
                databind();
            }
            if (0 == e.ColumnIndex)
            {
                if (MessageBox.Show("Are you sure to update?", "Confirmation!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    form_updEmployee m = new form_updEmployee(emp,new form_viewEmployee());
                    m.Show();
                    this.Close();

                }
                databind();
            }
        }

        private void form_viewEmployee_Load(object sender, EventArgs e)
        {

            BST.read("Employee.csv");
            List<EmployeeBL> list = BST.TreetoList();
            dataGridView1.DataSource=list;
        }
        public void databind()
        {
            dataGridView1.DataSource = null;
            List<EmployeeBL> list = BST.TreetoList();
            dataGridView1.DataSource = list;
            dataGridView1.Refresh();

        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            form_manager m = new form_manager();
            m.Show();
            this.Close();
        }
    }
}
