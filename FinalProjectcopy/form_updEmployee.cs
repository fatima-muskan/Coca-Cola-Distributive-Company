using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.BL;
using FinalProject.DL;

namespace FinalProject
{
    public partial class form_updEmployee : Form
    {
        form_viewEmployee view;
        private EmployeeBL NewEmployee;
        EmployeeDL BST = new EmployeeDL();
        public form_updEmployee(EmployeeBL NewEmployee,form_viewEmployee view)
        {
            this.NewEmployee = NewEmployee;
            this.view = view;
            InitializeComponent();
        }

        private void form_updEmployee_Load(object sender, EventArgs e)
        {
            BST.read("Employee.csv");
            txtBox_name.Text = NewEmployee.Name;
            txtBox_cnic.Text = NewEmployee.Cnic;
            txtBox_email.Text = NewEmployee.Email;
            txtBox_salary.Text=(NewEmployee.Salary).ToString();
            txtBox_dob.Text = NewEmployee.DOB;
            txtBox_digits.Text = NewEmployee.Phone;
            txtBox_pass.Text = NewEmployee.Password;
            cmb_role.Text = NewEmployee.Role;
        }

        private void txtBox_digits_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_cnic_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_cnic.Text))
            {
                e.Cancel = true;
                txtBox_cnic.Focus();
                errorCnic.SetError(txtBox_cnic, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorCnic.SetError(txtBox_cnic, "");
                if ((txtBox_cnic.Text).Length == 13 && Regex.IsMatch(txtBox_cnic.Text, @"\d"))
                {
                    e.Cancel = false;
                    errorCnic.SetError(txtBox_cnic, "");

                }
                else
                {
                    e.Cancel = true;
                    txtBox_cnic.Focus();
                    errorCnic.SetError(txtBox_cnic, "Invalid");
                }

            }
        }

        private void txtBox_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_name.Text))
            {
                e.Cancel = true;
                txtBox_name.Focus();
                errorName.SetError(txtBox_name, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorName.SetError(txtBox_name, "");
            }
        }

        private void txtBox_email_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_email.Text))
            {
                e.Cancel = true;
                txtBox_email.Focus();
                errorSalary.SetError(txtBox_email, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorSalary.SetError(txtBox_email, "");
                try
                {
                    new MailAddress(txtBox_email.Text);
                    e.Cancel = false;
                    errorSalary.SetError(txtBox_email, "");
                }

                catch
                {
                    e.Cancel = true;
                    txtBox_salary.Focus();
                    errorSalary.SetError(txtBox_email, "Invalid email! ");

                }
            }
        }

        private void txtBox_pass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_pass.Text))
            {
                e.Cancel = true;
                txtBox_pass.Focus();
                errorPassword.SetError(txtBox_pass, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorPassword.SetError(txtBox_pass, "");
                if ((txtBox_pass.Text).Length == 8 && Regex.IsMatch(txtBox_pass.Text, @"\d+\S"))
                {
                    e.Cancel = false;
                    errorPassword.SetError(txtBox_pass, "");

                }
                else
                {
                    e.Cancel = true;
                    txtBox_pass.Focus();
                    errorPassword.SetError(txtBox_pass, "Invalid");
                }

            }
        }

       

        private void txtBox_salary_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_salary.Text))
            {
                e.Cancel = true;
                txtBox_salary.Focus();
                errorSalary.SetError(txtBox_salary, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorSalary.SetError(txtBox_salary, "");
                if (int.Parse(txtBox_salary.Text) < 0)
                {
                    e.Cancel = true;
                    txtBox_salary.Focus();
                    errorSalary.SetError(txtBox_salary, "Negative Number is not allowes! ");
                }

                else
                {
                    e.Cancel = false;
                    errorSalary.SetError(txtBox_salary, "");
                }
            }
        }

        private void txtBox_dob_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtBox_number_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBox_digits.Text))
            {
                e.Cancel = true;
                txtBox_digits.Focus();
                errorDigit.SetError(txtBox_digits, "Textbox must be filled!");
            }
            else
            {
                e.Cancel = false;
                errorDigit.SetError(txtBox_digits, "");
                if ((txtBox_digits.Text).Length == 11 && Regex.IsMatch(txtBox_digits.Text, @"\d"))
                {
                    e.Cancel = false;
                    errorDigit.SetError(txtBox_digits, "");

                }
                else
                {
                    e.Cancel = true;
                    txtBox_digits.Focus();
                    errorDigit.SetError(txtBox_digits, "Invalid");
                }

            }
        }

        private void cmb_role_Validating(object sender, CancelEventArgs e)
        {
            if (cmb_role.SelectedIndex == -1)
            {
                e.Cancel = true;
                cmb_role.Focus();
                errorRole.SetError(cmb_role, "You must select a conversion type!!");
            }
            else
            {
                e.Cancel = false;
                errorRole.SetError(cmb_role, "");
            }
        }
        private void txtBox_salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txtBox_name.Text != "" && txtBox_cnic.Text != "" && txtBox_email.Text != "" && txtBox_salary.Text != "" && txtBox_pass.Text != ""&& txtBox_digits.Text != "" && cmb_role.Text != "" && txtBox_dob.Text!="")
            {
                EmployeeBL emp = new EmployeeBL(txtBox_name.Text, txtBox_cnic.Text, txtBox_email.Text, int.Parse(txtBox_salary.Text), txtBox_dob.Text, txtBox_digits.Text, txtBox_pass.Text, cmb_role.Text, NewEmployee.Id);
               
                BST.Update(emp);
                MessageBox.Show("Data Updated!!");
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Do you want to store in file?", "Dialog Box", buttons);
                if (result == DialogResult.Yes)
                {
                    List<EmployeeBL> list = BST.TreetoList();
                    BST.storeInFile("Employee.csv", list);
                    MessageBox.Show("Store in File!!");
                }
                view.databind();
            }
            else
            {
                MessageBox.Show("Data must entered!!");
            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            view.Show();
            this.Close();
        }
    }
}
