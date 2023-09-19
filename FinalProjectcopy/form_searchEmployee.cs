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

namespace FinalProject
{
    public partial class form_searchEmployee : Form
    {
        EmployeeDL BST = new EmployeeDL();
        public form_searchEmployee()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txtBox_Id.Text != "")
            {
                EmployeeBL emp = BST.search(int.Parse(txtBox_Id.Text));
                if (emp != null)
                {
                    lbl_details.Text = ("Name : " + emp.Name + "\n" + "Password : " + emp.Password + "\n" + "Salary : " + emp.Salary + "\n" + "DOB : " + emp.DOB + "\n" + "Email : " + emp.Email + "\n" + "CNIC : " + emp.Cnic + "\n" + "Phone Number : " + emp.Phone + "\n" + "Role : " + emp.Role + "\n").ToString();
                }
                else if (emp == null)
                {
                    lbl_details.Text = "User Not Found!!!";
                }
            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            form_manager m = new form_manager();
            m.Show();
            this.Close();
        }

        private void form_searchEmployee_Load(object sender, EventArgs e)
        {
            BST.read("Employee.csv");
        }

        private void txtBox_Id_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_Id.Text))
            {
                e.Cancel = true;
                txtBox_Id.Focus();
                errorId.SetError(txtBox_Id, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorId.SetError(txtBox_Id, "");
                if (int.Parse(txtBox_Id.Text) < 0)
                {
                    e.Cancel = true;
                    txtBox_Id.Focus();
                    errorId.SetError(txtBox_Id, "Invalid!!! ");
                }

                else
                {
                    e.Cancel = false;
                    errorId.SetError(txtBox_Id, "");
                }
            }
        }
    }
}
